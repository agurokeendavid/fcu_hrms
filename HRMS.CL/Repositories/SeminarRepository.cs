using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class SeminarRepository
    {
        public static async Task<int> InsertSeminarAsync(SeminarModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = @"INSERT INTO seminars (EmployeeId, SeminarName, SeminarLevelId, CertificatePath) VALUES (@EmployeeId, UPPER(@SeminarName), @SeminarLevelId, @CertificatePath)";
                var parameters = new DynamicParameters();
                parameters.Add("@EmployeeId", model.EmployeeId, DbType.Int32);
                parameters.Add("@SeminarName", model.SeminarName, DbType.String);
                parameters.Add("@SeminarLevelId", model.SeminarLevelId, DbType.Int32);
                parameters.Add("@CertificatePath", model.CertificatePath, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<IEnumerable<SeminarModel>> GetSeminarsAsync(string search)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = @"SELECT * FROM seminars INNER JOIN employees ON seminars.EmployeeId = employees.Id INNER JOIN seminar_level ON seminars.SeminarLevelId = seminar_level.Id WHERE employees.EmployeeNo = @search ORDER BY seminars.SeminarName";
                var parameters = new DynamicParameters();
                parameters.Add("search", search, DbType.String);
                return await connection.QueryAsync<SeminarModel, EmployeeModel, SeminarLevelModel, SeminarModel>(query,
                    (seminar, employee, seminarLevel) =>
                    {
                        seminar.Employee = employee;
                        seminar.SeminarLevel = seminarLevel;
                        return seminar;
                    }, parameters);
            }
        }

        public static async Task<int> UpdateSeminarAsync(SeminarModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE seminars SET SeminarName = UPPER(@SeminarName), SeminarLevelId = @SeminarLevelId, CertificatePath = @CertificatePath WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("SeminarName", model.SeminarName, DbType.String);
                parameters.Add("SeminarLevelId", model.SeminarLevelId, DbType.Int32);
                parameters.Add("CertificatePath", model.CertificatePath, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<SeminarModel> GetSeminarAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM seminars INNER JOIN employees ON seminars.EmployeeId = employees.Id WHERE seminars.Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                var result = await connection.QueryAsync<SeminarModel, EmployeeModel, SeminarModel>(query,
                    (seminar, employee) =>
                    {
                        seminar.Employee = employee;
                        return seminar;
                    }, parameters);
                return result.SingleOrDefault();
            }
        }

        public static async Task<int> DeleteSeminarAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM seminars WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
