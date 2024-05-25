using System.Data.SqlClient;

namespace coreWebApplication
{
    public class ConnectionStrings
    {
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
        {
            DataSource = "MYOTHETPC\\MSSQLSERVER2012",
            InitialCatalog = "CourseraDB",
            UserID = "sa",
            Password = "admin123!",
            TrustServerCertificate = true
        };
    }
}
