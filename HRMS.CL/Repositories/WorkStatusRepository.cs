using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class WorkStatusRepository
    {
        public static async Task<IEnumerable<WorkStatusModel>> GetWorkStatusAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM work_status ORDER BY WorkStatusName";
                return await connection.QueryAsync<WorkStatusModel>(query);
            }
        }
    }
}
