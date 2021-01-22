using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class LeaveTypeRepository
    {
        public static async Task<int> InsertLeaveTypeAsync(LeaveTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "insert into leave_types (LeaveType, LeaveCredits) VALUES (upper(@LeaveType), @LeaveCredits)";
                var parameters = new DynamicParameters();
                parameters.Add("LeaveType", model.LeaveType, DbType.String);
                parameters.Add("LeaveCredits", model.LeaveCredits, DbType.Double);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<IEnumerable<LeaveTypeModel>> GetLeaveTypesAsync()
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "select * from leave_types order by LeaveType";
                return await connection.QueryAsync<LeaveTypeModel>(query);
            }
        }

        public static async Task<int> UpdateLeaveTypeAsync(LeaveTypeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "update leave_types set LeaveType = upper(@LeaveType), LeaveCredits = @LeaveCredits where Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("LeaveType", model.LeaveType, DbType.String);
                parameters.Add("LeaveCredits", model.LeaveCredits, DbType.Double);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<LeaveTypeModel> GetLeaveTypeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM leave_types WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<LeaveTypeModel>(query, parameters);
            }
        }

        public static async Task<int> DeleteLeaveTypeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "delete from leave_types where Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
