using System.Data;
using Microsoft.Data.SqlClient;

namespace Bai6_2_HRMPayrollSystem.DAL
{
    public class ChamCongDAL
    {
        public void KhoiTaoBangChamCongThang(string thangNam)
        {
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = @"
                    INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa)
                    SELECT nv.MaNV, @ThangNam, 22, 0, 0
                    FROM NhanVien nv
                    WHERE NOT EXISTS (
                        SELECT 1 FROM BangChamCong cc WHERE cc.MaNV = nv.MaNV AND cc.ThangNam = @ThangNam
                    )";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Nạp bảng chấm công theo mô hình ngắt kết nối (Disconnected Model: SqlDataAdapter + DataTable)
        /// </summary>
        public DataTable LoadBangChamCong(string thangNam, out SqlDataAdapter adapter)
        {
            KhoiTaoBangChamCongThang(thangNam);

            SqlConnection conn = DbConnectionHelper.GetConnection();
            string sql = "SELECT MaCong, MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa FROM BangChamCong WHERE ThangNam = @ThangNam ORDER BY MaNV";
            adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangNam);

            // Tạo SqlCommandBuilder để tự động sinh lệnh Insert/Update/Delete
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "BangChamCong");
            return ds.Tables["BangChamCong"]!;
        }

        public int SaveBangChamCong(SqlDataAdapter adapter, DataTable dt)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            return adapter.Update(dt);
        }
    }
}
