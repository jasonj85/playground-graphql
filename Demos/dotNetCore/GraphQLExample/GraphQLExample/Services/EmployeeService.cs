using GraphQLExample.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;

        public EmployeeService(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public async Task<Employee> Create(Employee employee)
        {
            var data = new Employee
            {
                Name = employee.Name,
                Designation = employee.Designation,
            };

            await _dbContext.Employees.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data;
        }

        public async Task<bool> Delete(DeleteVM deleteVM)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == deleteVM.Id);
            
            if (employee is not null)
            {
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees.AsQueryable();
        }

        public class DeleteVM
        {
            public int Id { get; set; }
        }
    }
}
