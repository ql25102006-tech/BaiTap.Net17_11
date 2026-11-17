using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Bai6_2_HRMPayrollSystem.DAL
{
    public static class DbConnectionHelper
    {
        public static string ConnectionString
        {
            get
            {
                var setting = ConfigurationManager.ConnectionStrings["HRMDB"];
                if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
                {
                    return setting.ConnectionString;
                }
                return @"Data Source=localhost\QUYEN;Initial Catalog=HRMDB;Integrated Security=True;TrustServerCertificate=True;";
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
