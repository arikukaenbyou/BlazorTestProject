using System.Collections.Generic;
using System.Threading.Tasks;
using TrebasiewiczCompanyServer.Models;

namespace TrebasiewiczCompanyServer.Sql
{
    public interface IEmployeeData
    {
        Task<List<Employee>> GetEmployees();
        Task InsertEmployee(Employee employee);
        Task DeleteEmployee(Employee employee);
        Task AddWorkingTime(WorkingTime workingTime);
        Task ResetWorkingTime(WorkingTime workingTime);
    }
}