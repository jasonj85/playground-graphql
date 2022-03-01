using Microsoft.EntityFrameworkCore;

namespace GraphQLExample.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Jason", Designation = "IT consultant"},
                new Employee { Id = 2, Name = "Henry", Designation = "Store Assistant" },
                new Employee { Id = 3, Name = "Susan", Designation = "Football Coach" },
                new Employee { Id = 4, Name = "Terri", Designation = "School Teacher" },
                new Employee { Id = 5, Name = "Aaron", Designation = "Navy Officer" }
                );
        }
    }
}
