using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.DAL
{
    public class BangLuongDAL
    {
        public int ChotLuongThang(string thangNam)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Kiểm tra xem tháng đã chốt lương chưa
                        string sqlCheck = "SELECT COUNT(*) FROM BangLuong WHERE ThangNam = @ThangNam";
                        using (SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, trans))
                        {
                            cmdCheck.Parameters.AddWithValue("@ThangNam", thangNam);
                            int existing = Convert.ToInt32(cmdCheck.ExecuteScalar());
                            if (existing > 0)
                            {
                                throw new InvalidOperationException($"Bảng lương tháng [{thangNam}] đã được chốt trước đó! Giao dịch đã Rollback.");
                            }
                        }

                        // 2. Lấy dữ liệu chấm công và lương cơ bản để tính Thực lĩnh
                        string sqlRead = @"
                            SELECT cc.MaNV, nv.LuongCoBan, nv.HeSoLuong, cc.SoNgayCong, cc.SoGioOT
                            FROM BangChamCong cc
                            INNER JOIN NhanVien nv ON cc.MaNV = nv.MaNV
                            WHERE cc.ThangNam = @ThangNam";

                        var danhSachTinhLuong = new List<(int MaNV, decimal ThucLinh)>();
                        using (SqlCommand cmdRead = new SqlCommand(sqlRead, conn, trans))
                        {
                            cmdRead.Parameters.AddWithValue("@ThangNam", thangNam);
                            using (SqlDataReader reader = cmdRead.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int maNV = reader.GetInt32(0);
                                    decimal luongCB = reader.GetDecimal(1);
                                    double heSo = reader.GetDouble(2);
                                    double ngayCong = reader.GetDouble(3);
                                    double gioOT = reader.GetDouble(4);

                                    // Công thức: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)
                                    decimal thucLinh = (luongCB * (decimal)heSo / 22m) * (decimal)ngayCong + ((decimal)gioOT * 50000m);
                                    danhSachTinhLuong.Add((maNV, Math.Round(thucLinh, 0)));
                                }
                            }
                        }

                        if (danhSachTinhLuong.Count == 0)
                        {
                            throw new InvalidOperationException($"Chưa có dữ liệu chấm công trong tháng [{thangNam}] để chốt lương!");
                        }

                        // 3. Chèn vào BangLuong cho toàn bộ nhân viên
                        string sqlInsert = "INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh) VALUES (@MaNV, @ThangNam, @ThucLinh)";
                        foreach (var item in danhSachTinhLuong)
                        {
                            using (SqlCommand cmdIns = new SqlCommand(sqlInsert, conn, trans))
                            {
                                cmdIns.Parameters.AddWithValue("@MaNV", item.MaNV);
                                cmdIns.Parameters.AddWithValue("@ThangNam", thangNam);
                                cmdIns.Parameters.AddWithValue("@ThucLinh", item.ThucLinh);
                                cmdIns.ExecuteNonQuery();
                            }
                        }

                        // 4. Khóa dữ liệu chấm công tháng này
                        string sqlLock = "UPDATE BangChamCong SET DaKhoa = 1 WHERE ThangNam = @ThangNam";
                        using (SqlCommand cmdLock = new SqlCommand(sqlLock, conn, trans))
                        {
                            cmdLock.Parameters.AddWithValue("@ThangNam", thangNam);
                            cmdLock.ExecuteNonQuery();
                        }

                        trans.Commit();
                        return danhSachTinhLuong.Count;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<BangLuongDTO> GetBangLuongByThang(string thangNam)
        {
            var list = new List<BangLuongDTO>();
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    SELECT bl.MaLuong, bl.MaNV, nv.HoTen, pb.TenPB, bl.ThangNam,
                           nv.LuongCoBan, nv.HeSoLuong, cc.SoNgayCong, cc.SoGioOT, bl.ThucLinh
                    FROM BangLuong bl
                    INNER JOIN NhanVien nv ON bl.MaNV = nv.MaNV
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    LEFT JOIN BangChamCong cc ON bl.MaNV = cc.MaNV AND bl.ThangNam = cc.ThangNam
                    WHERE bl.ThangNam = @ThangNam
                    ORDER BY bl.MaNV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new BangLuongDTO
                            {
                                MaLuong = reader.GetInt32(0),
                                MaNV = reader.GetInt32(1),
                                HoTen = reader.GetString(2),
                                TenPB = reader.GetString(3),
                                ThangNam = reader.GetString(4),
                                LuongCoBan = reader.GetDecimal(5),
                                HeSoLuong = reader.GetDouble(6),
                                SoNgayCong = reader.IsDBNull(7) ? 0 : reader.GetDouble(7),
                                SoGioOT = reader.IsDBNull(8) ? 0 : reader.GetDouble(8),
                                ThucLinh = reader.GetDecimal(9)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
