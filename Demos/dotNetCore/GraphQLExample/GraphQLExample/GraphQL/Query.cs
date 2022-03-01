using GraphQLExample.Models;
using GraphQLExample.Services;

namespace GraphQLExample.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;
        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IQueryable<Employee> Employees => _employeeService.GetAll();
    }
}
