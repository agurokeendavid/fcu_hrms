using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class UserRepository
    {
        public static async Task<UserModel> GetUserAccountAsync(string username, string password)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM users WHERE LOWER(Username) = LOWER(@Username) AND Password = SHA1(@Password)";
                var parameters = new DynamicParameters();
                parameters.Add("Username", username, DbType.String);
                parameters.Add("Password", password, DbType.String);
                return await connection.QuerySingleOrDefaultAsync<UserModel>(query, parameters);
            }
        }

        public static async Task<int> InsertUserAsync(UserModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "INSERT INTO users (Username, Password, FirstName, MiddleName, LastName) VALUES (@Username, SHA1(@Password), UPPER(@FirstName), UPPER(@MiddleName), UPPER(@LastName))";
                var parameters = new DynamicParameters();
                parameters.Add("Username", model.Username, DbType.String);
                parameters.Add("Password", model.Password, DbType.String);
                parameters.Add("FirstName", model.FirstName, DbType.String);
                parameters.Add("MiddleName", model.MiddleName, DbType.String);
                parameters.Add("LastName", model.LastName, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> UpdatePasswordAsync(UserModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE users SET Password = SHA1(@Password) WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Password", model.Password, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<bool> IsCurrentPasswordSame(int id, string password)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT COUNT(1) FROM users WHERE Id = @Id AND Password = SHA1(@Password)";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                parameters.Add("Password", password, DbType.String);
                return await connection.ExecuteScalarAsync<bool>(query, parameters);
            }
        }
    }
}
