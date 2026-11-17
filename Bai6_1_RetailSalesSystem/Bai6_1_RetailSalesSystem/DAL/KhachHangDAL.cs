using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetAll()
        {
            var list = new List<KhachHangDTO>();
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang ORDER BY MaKH";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new KhachHangDTO
                            {
                                MaKH = reader.GetInt32(0),
                                TenKH = reader.GetString(1),
                                DienThoai = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                DiemTichLuy = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Insert(KhachHangDTO kh)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES (@TenKH, @DienThoai, @DiemTichLuy)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                    cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiemTichLuy = @DiemTichLuy WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                    cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                    cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int maKH)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
