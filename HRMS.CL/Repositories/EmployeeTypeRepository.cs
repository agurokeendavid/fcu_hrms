using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class EmployeeTypeRepository
    {
        public static async Task<IEnumerable<EmployeeTypeModel>> GetEmployeeTypesAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM employee_types ORDER BY EmployeeTypeName";
                return await connection.QueryAsync<EmployeeTypeModel>(query);
            }
        }

        public static async Task<int> InsertEmployeeTypeAsync(EmployeeTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "INSERT INTO employee_types (EmployeeTypeName) VALUES (UPPER(@EmployeeTypeName))";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeTypeName", model.EmployeeTypeName, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> UpdateEmployeeTypeAsync(EmployeeTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE employee_types SET EmployeeTypeName = UPPER(@EmployeeTypeName) WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeTypeName", model.EmployeeTypeName, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<int> DeleteEmployeeTypeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM employee_types WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<EmployeeTypeModel> GetEmployeeTypeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM employee_types WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<EmployeeTypeModel>(query, parameters);
            }
        }
    }
}
