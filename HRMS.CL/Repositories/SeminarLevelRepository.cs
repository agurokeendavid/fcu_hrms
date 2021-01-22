using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class SeminarLevelRepository
    {
        public static async Task<IEnumerable<SeminarLevelModel>> GetSeminarLevelAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM seminar_level ORDER BY SeminarLevelName";
                return await connection.QueryAsync<SeminarLevelModel>(query);
            }
        }

        public static async Task<SeminarLevelModel> GetSingleSeminarLevelAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM seminar_level WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<SeminarLevelModel>(query, parameters);
            }
        }
    }
}
