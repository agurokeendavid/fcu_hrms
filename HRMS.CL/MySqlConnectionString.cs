using System.Configuration;

namespace HRMS.CL
{
    public class MySqlConnectionString
    {
        public static string GetConnectionString(string connectionName = "FCU_HRMS")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
    }
}
