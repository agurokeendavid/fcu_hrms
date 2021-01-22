using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class OfficeRepository
    {
        public static async Task<IEnumerable<OfficeModel>> GetOfficesAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM offices ORDER BY OfficeName";
                return await connection.QueryAsync<OfficeModel>(query);
            }
        }

        public static async Task<int> InsertOfficeAsync(OfficeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "INSERT INTO offices (OfficeName) VALUES (UPPER(@OfficeName))";
                var parameters = new DynamicParameters();
                parameters.Add("OfficeName", model.OfficeName, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> UpdateOfficeAsync(OfficeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE offices SET OfficeName = UPPER(@OfficeName) WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("OfficeName", model.OfficeName, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> DeleteOfficeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM offices WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<OfficeModel> GetOfficeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM offices WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<OfficeModel>(query, parameters);
            }
        }
    }
}
