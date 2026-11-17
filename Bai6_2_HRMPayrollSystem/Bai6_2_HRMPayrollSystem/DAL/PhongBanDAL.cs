using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.DAL
{
    public class PhongBanDAL
    {
        public List<PhongBanDTO> GetAll()
        {
            var list = new List<PhongBanDTO>();
            using (SqlConnection conn = DbConnectionHelper.GetConnection())
            {
                string sql = "SELECT MaPB, TenPB, Mota FROM PhongBan ORDER BY MaPB";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new PhongBanDTO
                            {
                                MaPB = reader.GetInt32(0),
                                TenPB = reader.GetString(1),
                                Mota = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
