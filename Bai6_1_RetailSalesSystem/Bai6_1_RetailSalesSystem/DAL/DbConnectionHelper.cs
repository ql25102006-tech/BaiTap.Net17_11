using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Bai6_1_RetailSalesSystem.DAL
{
    public static class DbConnectionHelper
    {
        public static string ConnectionString
        {
            get
            {
                var setting = ConfigurationManager.ConnectionStrings["SalesDB"];
                if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
                {
                    return setting.ConnectionString;
                }
                return @"Data Source=localhost\QUYEN;Initial Catalog=SalesDB;Integrated Security=True;TrustServerCertificate=True;";
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
