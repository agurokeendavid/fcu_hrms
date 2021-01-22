using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class LeaveRepository
    {
        public static async Task<int> InsertLeaveAsync(LeaveModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "INSERT INTO leaves (EmployeeId, LeaveTypeId, LeaveFrom, LeaveTo, Reason, LeaveCredits) VALUES (@EmployeeId, @LeaveTypeId, @LeaveFrom, @LeaveTo, UPPER(@Reason), @LeaveCredits)";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeId", model.EmployeeId, DbType.Int32);
                parameters.Add("LeaveTypeId", model.LeaveTypeId, DbType.Int32);
                parameters.Add("LeaveFrom", model.LeaveFrom, DbType.Date);
                parameters.Add("LeaveTo", model.LeaveTo, DbType.Date);
                parameters.Add("Reason", model.Reason, DbType.String);
                parameters.Add("LeaveCredits", model.LeaveCredits, DbType.Double);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<IEnumerable<LeaveModel>> GetLeavesAsync(string search)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM leaves INNER JOIN employees ON leaves.EmployeeId = employees.Id INNER JOIN leave_types ON leaves.LeaveTypeId = leave_types.Id WHERE employees.EmployeeNo = @search ORDER BY leaves.DateCreated DESC";
                var parameters = new DynamicParameters();
                parameters.Add("search", search, DbType.String);
                return await connection.QueryAsync<LeaveModel, EmployeeModel, LeaveTypeModel, LeaveModel>(query, (leave, employee, leaveType) =>
                {
                    leave.Employee = employee;
                    leave.LeaveType = leaveType;
                    return leave;
                }, parameters);
            }
        }

        public static async Task<double> GetLeaveCreditsAsync(int empId, int leaveTypeId)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "select SUM(LeaveCredits) FROM leaves where EmployeeId = @EmployeeId AND LeaveTypeId = @LeaveTypeId";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeId", empId, DbType.Int32);
                parameters.Add("LeaveTypeId", leaveTypeId, DbType.Int32);
                return await connection.ExecuteScalarAsync<double>(query, parameters);
            }
        }

        public static async Task<int> DeleteLeaveAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "delete from leaves where Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
