using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrebasiewiczCompanyServer.Models;


namespace TrebasiewiczCompanyServer.Sql
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;
        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Employee>> GetEmployees()
        {
            string sql = @"select employeeId, name, surname, employeetype, worklocation, ISNULL(sum(workingtimevalue), 0) as  workingtimevalue
                            from [dbo].[Employees] 
                            left join [dbo].[WorkingTime] on [EmployeeId] = [WorkingTimeEmployeeId]
							group by EmployeeId, name, SurName, WorkLocation, employeetype";

            return _db.LoadData<Employee, dynamic>(sql, new { });
        }        
        public Task InsertEmployee(Employee employee)
        {
            string sql = @"insert into dbo.Employees (Name, Surname, EmployeeType, WorkLocation) values (@Name, @Surname, @EmployeeType, @WorkLocation )";

            return _db.SaveData(sql, employee);
        }
        public Task DeleteEmployee(Employee employee)
        {
            string sql = @"delete from dbo.Employees where employeeid = @EmployeeId";

            return _db.SaveData(sql, employee);
        }
        public Task AddWorkingTime(WorkingTime workingTime)
        {
            string sql = @"insert into dbo.WorkingTime values (@WorkingTimeValue, @WorkingTimeEmployeeId)";

            return _db.SaveData(sql, workingTime);
        }
        public Task ResetWorkingTime(WorkingTime workingTime)
        {
            string sql = @"delete from dbo.WorkingTime where workingTimeEmployeeId = (@WorkingTimeEmployeeId)";

            return _db.SaveData(sql, workingTime);
        }

    }
}
