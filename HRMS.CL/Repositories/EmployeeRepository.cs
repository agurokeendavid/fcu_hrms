using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using HRMS.CL.Models;
using MySql.Data.MySqlClient;

namespace HRMS.CL.Repositories
{
    public class EmployeeRepository
    {
        public static async Task<int> InsertEmployeeAsync(EmployeeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = @"INSERT INTO employees (EmployeeNo, FirstName, MiddleName, LastName, Address, Gender, Dob, PlaceOfBirth, ContactNo, EmailAddress, CivilStatus, EmployeeTypeId, OfficeId, PositionId, WorkStatusId, HighestDegree, AcquiredDegree, WorkExperience, ResumePath) VALUES (@EmployeeNo, UPPER(@FirstName), UPPER(@MiddleName), UPPER(@LastName), UPPER(@Address), @Gender, @Dob, UPPER(@PlaceOfBirth), @ContactNo, @EmailAddress, @CivilStatus, @EmployeeTypeId, @OfficeId, @PositionId, @WorkStatusId, @HighestDegree, UPPER(@AcquiredDegree), UPPER(@WorkExperience), @ResumePath)";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeNo", model.EmployeeNo, DbType.String);
                parameters.Add("FirstName", model.FirstName, DbType.String);
                parameters.Add("MiddleName", model.MiddleName, DbType.String);
                parameters.Add("LastName", model.LastName, DbType.String);
                parameters.Add("Address", model.Address, DbType.String);
                parameters.Add("Gender", model.Gender, DbType.String);
                parameters.Add("Dob", model.Dob, DbType.Date);
                parameters.Add("PlaceOfBirth", model.PlaceOfBirth, DbType.String);
                parameters.Add("ContactNo", model.ContactNo, DbType.String);
                parameters.Add("EmailAddress", model.EmailAddress, DbType.String);
                parameters.Add("CivilStatus", model.CivilStatus, DbType.String);
                parameters.Add("EmployeeTypeId", model.EmployeeTypeId, DbType.Int32);
                parameters.Add("OfficeId", model.OfficeId, DbType.Int32);
                parameters.Add("PositionId", model.PositionId, DbType.Int32);
                parameters.Add("WorkStatusId", model.WorkStatusId, DbType.Int32);
                parameters.Add("HighestDegree", model.HighestDegree, DbType.String);
                parameters.Add("AcquiredDegree", model.AcquiredDegree, DbType.String);
                parameters.Add("WorkExperience", model.WorkExperience, DbType.String);
                parameters.Add("ResumePath", model.ResumePath, DbType.String);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<IEnumerable<EmployeeModel>> GetEmployeesAsync(string search)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = @"SELECT * FROM employees A INNER JOIN employee_types B ON A.EmployeeTypeId = B.Id INNER JOIN offices C ON A.OfficeId = C.Id INNER JOIN positions D ON A.PositionId = D.Id INNER JOIN work_status E ON A.WorkStatusId = E.Id WHERE (A.FirstName LIKE @keyword OR A.MiddleName LIKE @keyword OR A.LastName LIKE @keyword OR C.OfficeName LIKE @keyword) ORDER BY A.LastName";
                var parameters = new DynamicParameters();
                parameters.Add("keyword", $@"%{search}%", DbType.String);
                return await connection.QueryAsync<EmployeeModel, EmployeeTypeModel, OfficeModel, PositionModel, WorkStatusModel, EmployeeModel>(query,
                    (employee, employeeType, office, position, workStatus) =>
                    {
                        employee.EmployeeType = employeeType;
                        employee.Office = office;
                        employee.Position = position;
                        employee.WorkStatus = workStatus;
                        return employee;
                    }, parameters);
            }
        }

        public static async Task<EmployeeModel> GetEmployeeByEmployeeNoAsync(string empNo)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM employees WHERE EmployeeNo = @EmployeeNo";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeNo", empNo, DbType.String);
                return await connection.QuerySingleOrDefaultAsync<EmployeeModel>(query, parameters);
            }
        }

        public static async Task<int> DeleteEmployeeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "DELETE FROM employees WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }

        public static async Task<EmployeeModel> GetEmployeeAsync(int id)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "SELECT * FROM employees WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);
                return await connection.QuerySingleOrDefaultAsync<EmployeeModel>(query, parameters);
            }
        }

        public static async Task<int> UpdateEmployeeAsync(EmployeeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(MySqlConnectionString.GetConnectionString()))
            {
                string query = "UPDATE employees SET EmployeeNo = @EmployeeNo, FirstName = UPPER(@FirstName), MiddleName = UPPER(@MiddleName), LastName = UPPER(@LastName), Address = UPPER(@Address), Gender = @Gender, Dob = @Dob, PlaceOfBirth = UPPER(@PlaceOfBirth), ContactNo = @ContactNo, EmailAddress = @EmailAddress, CivilStatus = @CivilStatus, EmployeeTypeId = @EmployeeTypeId, OfficeId = @OfficeId, PositionId = @PositionId, WorkStatusId = @WorkStatusId, HighestDegree = @HighestDegree, AcquiredDegree = @AcquiredDegree, WorkExperience = @WorkExperience, ResumePath = @ResumePath WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("EmployeeNo", model.EmployeeNo, DbType.String);
                parameters.Add("FirstName", model.FirstName, DbType.String);
                parameters.Add("MiddleName", model.MiddleName, DbType.String);
                parameters.Add("LastName", model.LastName, DbType.String);
                parameters.Add("Address", model.Address, DbType.String);
                parameters.Add("Gender", model.Gender, DbType.String);
                parameters.Add("Dob", model.Dob, DbType.Date);
                parameters.Add("PlaceOfBirth", model.PlaceOfBirth, DbType.String);
                parameters.Add("ContactNo", model.ContactNo, DbType.String);
                parameters.Add("EmailAddress", model.EmailAddress, DbType.String);
                parameters.Add("CivilStatus", model.CivilStatus, DbType.String);
                parameters.Add("EmployeeTypeId", model.EmployeeTypeId, DbType.Int32);
                parameters.Add("OfficeId", model.OfficeId, DbType.Int32);
                parameters.Add("PositionId", model.PositionId, DbType.Int32);
                parameters.Add("WorkStatusId", model.WorkStatusId, DbType.Int32);
                parameters.Add("HighestDegree", model.HighestDegree, DbType.String);
                parameters.Add("AcquiredDegree", model.AcquiredDegree, DbType.String);
                parameters.Add("WorkExperience", model.WorkExperience, DbType.String);
                parameters.Add("ResumePath", model.ResumePath, DbType.String);
                parameters.Add("Id", model.Id, DbType.Int32);
                return await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
