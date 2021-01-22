using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class PositionRepository
    {
        public static async Task<IEnumerable<PositionModel>> GetPositionsAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM positions ORDER BY PositionName";
                return await connection.QueryAsync<PositionModel>(query);
            }
        }

        public static async Task<int> InsertPositionAsync(PositionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "INSERT INTO positions (PositionName) VALUES (UPPER(@PositionName))";
                var parameters = new DynamicParameters();
                parameters.Add("PositionName", model.PositionName, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> UpdatePositionAsync(PositionModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE positions SET PositionName = UPPER(@PositionName) WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("PositionName", model.PositionName, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> DeletePositionAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM positions WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<PositionModel> GetPositionAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM positions WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<PositionModel>(query, parameters);
            }
        }
    }
}
