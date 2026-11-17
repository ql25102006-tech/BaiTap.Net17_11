using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.DAL
{
    public class NhanVienDAL
    {
        public List<NhanVienDTO> GetAll()
        {
            return Search(string.Empty, null);
        }

        public List<NhanVienDTO> Search(string keyword, int? maPB)
        {
            var list = new List<NhanVienDTO>();
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.CCCD, nv.MaPB, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong
                    FROM NhanVien nv
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    WHERE (@Keyword = '' OR nv.HoTen LIKE @KeywordPattern OR nv.CCCD LIKE @KeywordPattern OR pb.TenPB LIKE @KeywordPattern)
                      AND (@MaPB IS NULL OR nv.MaPB = @MaPB)
                    ORDER BY nv.MaNV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    string kw = keyword?.Trim() ?? string.Empty;
                    cmd.Parameters.AddWithValue("@Keyword", kw);
                    cmd.Parameters.AddWithValue("@KeywordPattern", "%" + kw + "%");
                    cmd.Parameters.AddWithValue("@MaPB", (object?)maPB ?? DBNull.Value);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new NhanVienDTO
                            {
                                MaNV = reader.GetInt32(0),
                                HoTen = reader.GetString(1),
                                NgaySinh = reader.IsDBNull(2) ? DateTime.Today : reader.GetDateTime(2),
                                CCCD = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                MaPB = reader.GetInt32(4),
                                TenPB = reader.GetString(5),
                                LuongCoBan = reader.GetDecimal(6),
                                HeSoLuong = reader.GetDouble(7)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong)
                    VALUES (@HoTen, @NgaySinh, @CCCD, @MaPB, @LuongCoBan, @HeSoLuong)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                    cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                    cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    UPDATE NhanVien
                    SET HoTen = @HoTen, NgaySinh = @NgaySinh, CCCD = @CCCD, MaPB = @MaPB, LuongCoBan = @LuongCoBan, HeSoLuong = @HeSoLuong
                    WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                    cmd.Parameters.AddWithValue("@CCCD", nv.CCCD);
                    cmd.Parameters.AddWithValue("@MaPB", nv.MaPB);
                    cmd.Parameters.AddWithValue("@LuongCoBan", nv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@HeSoLuong", nv.HeSoLuong);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ChuyenPhongBan(int maNV, int maPBMoi)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "UPDATE NhanVien SET MaPB = @MaPB WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPB", maPBMoi);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int maNV)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
