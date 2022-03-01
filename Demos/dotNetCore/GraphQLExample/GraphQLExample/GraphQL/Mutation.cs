using GraphQLExample.Models;
using GraphQLExample.Services;

namespace GraphQLExample.GraphQL
{
    public class Mutation
    {
        private readonly IEmployeeService _employeeService;

        public Mutation(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        public async Task<Employee> Employee(Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(EmployeeService.DeleteVM deleteVM) => await _employeeService.Delete(deleteVM);
    }
}
