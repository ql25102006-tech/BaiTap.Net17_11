using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.DAL
{
    public class HoaDonDAL
    {
        public int ThanhToanHoaDon(HoaDonDTO hoaDon)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Chèn 1 bản ghi vào bảng HoaDon và lấy MaHD vừa sinh
                        string sqlInsertHD = @"
                            INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien)
                            OUTPUT INSERTED.MaHD
                            VALUES (GETDATE(), @MaNV, @MaKH, @TongTien)";

                        int newMaHD;
                        using (SqlCommand cmdHD = new SqlCommand(sqlInsertHD, conn, trans))
                        {
                            cmdHD.Parameters.AddWithValue("@MaNV", hoaDon.MaNV);
                            cmdHD.Parameters.AddWithValue("@MaKH", (object?)hoaDon.MaKH ?? DBNull.Value);
                            cmdHD.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                            newMaHD = (int)cmdHD.ExecuteScalar();
                        }

                        // 2. Xử lý từng sản phẩm trong ChiTietHoaDon và trừ SoLuongTon
                        foreach (var item in hoaDon.ChiTiet)
                        {
                            // Kiểm tra tồn kho trước khi trừ
                            string sqlCheckStock = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
                            int currentStock = 0;
                            using (SqlCommand cmdCheck = new SqlCommand(sqlCheckStock, conn, trans))
                            {
                                cmdCheck.Parameters.AddWithValue("@MaSP", item.MaSP);
                                object? res = cmdCheck.ExecuteScalar();
                                if (res == null || res == DBNull.Value)
                                {
                                    throw new InvalidOperationException($"Sản phẩm [{item.MaSP}] không tồn tại trong hệ thống!");
                                }
                                currentStock = Convert.ToInt32(res);
                            }

                            if (currentStock < item.SoLuong)
                            {
                                throw new InvalidOperationException(
                                    $"Không đủ tồn kho cho sản phẩm [{item.MaSP} - {item.TenSP}]! Hiện còn: {currentStock}, Yêu cầu bán: {item.SoLuong}. Giao dịch đã Rollback.");
                            }

                            // Chèn ChiTietHoaDon
                            string sqlInsertCT = @"
                                INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                                VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                            using (SqlCommand cmdCT = new SqlCommand(sqlInsertCT, conn, trans))
                            {
                                cmdCT.Parameters.AddWithValue("@MaHD", newMaHD);
                                cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                                cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                                cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                                cmdCT.ExecuteNonQuery();
                            }

                            // Trừ SoLuongTon trong SanPham
                            string sqlUpdateStock = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";
                            using (SqlCommand cmdStock = new SqlCommand(sqlUpdateStock, conn, trans))
                            {
                                cmdStock.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                                cmdStock.Parameters.AddWithValue("@MaSP", item.MaSP);
                                cmdStock.ExecuteNonQuery();
                            }
                        }

                        // 3. Cộng điểm tích lũy cho Khách hàng (DiemTichLuy += TongTien / 100000)
                        if (hoaDon.MaKH.HasValue)
                        {
                            int diemCong = (int)(hoaDon.TongTien / 100000m);
                            if (diemCong > 0)
                            {
                                string sqlUpdatePoints = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @Diem WHERE MaKH = @MaKH";
                                using (SqlCommand cmdPts = new SqlCommand(sqlUpdatePoints, conn, trans))
                                {
                                    cmdPts.Parameters.AddWithValue("@Diem", diemCong);
                                    cmdPts.Parameters.AddWithValue("@MaKH", hoaDon.MaKH.Value);
                                    cmdPts.ExecuteNonQuery();
                                }
                            }
                        }

                        // 4. Commit transaction khi mọi bước đều thành công
                        trans.Commit();
                        return newMaHD;
                    }
                    catch
                    {
                        // Rollback toàn bộ giao dịch nếu có bất kỳ lỗi nào xảy ra
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public decimal GetDoanhThuNgay()
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    object? res = cmd.ExecuteScalar();
                    return res != null && res != DBNull.Value ? Convert.ToDecimal(res) : 0m;
                }
            }
        }

        public decimal GetDoanhThuThang()
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    object? res = cmd.ExecuteScalar();
                    return res != null && res != DBNull.Value ? Convert.ToDecimal(res) : 0m;
                }
            }
        }

        public List<TopSanPhamDTO> GetTop5SanPhamBanChay()
        {
            var list = new List<TopSanPhamDTO>();
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    SELECT TOP 5 ct.MaSP, sp.TenSP, SUM(ct.SoLuong) AS TongSoLuongBan, SUM(ct.SoLuong * ct.DonGia) AS TongDoanhThu
                    FROM ChiTietHoaDon ct
                    INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                    GROUP BY ct.MaSP, sp.TenSP
                    ORDER BY TongSoLuongBan DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TopSanPhamDTO
                            {
                                MaSP = reader.GetString(0),
                                TenSP = reader.GetString(1),
                                TongSoLuongBan = reader.GetInt32(2),
                                TongDoanhThu = reader.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
