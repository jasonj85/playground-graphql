using GraphQLExample.Models;
using static GraphQLExample.Services.EmployeeService;

namespace GraphQLExample.Services
{
    public interface IEmployeeService
    {
        Task<Employee> Create(Employee employee);
        Task<bool> Delete(DeleteVM deleteVM);

        IQueryable<Employee> GetAll();
    }
}
