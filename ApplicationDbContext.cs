using EmployeesDbApp.DbModel;
using Microsoft.EntityFrameworkCore;

namespace EmployeesDBApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void WriteDummyRecords()
        {
            var emps = new List<Employee>();
            emps.Add(new Employee
            {
                Email = "sobaka@1",
                FirstName = "Bob",
                LastName = "Bobov",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now),
                Salary = 120000.5m
            });

            emps.Add(new Employee
            {
                Email = "example@mail.ru",
                FirstName = "Александр",
                LastName = "Зотиков",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now),
                Salary = 1806000.77m
            });

            emps.Add(new Employee
            {
                Email = "@yandex.ru",
                FirstName = "Вениамин",
                LastName = "Лавров",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Now),
                Salary = 120000.5m
            });

            Employees.AddRange(emps);
            SaveChanges();
        }

        private ApplicationDbContext() : base() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email)
                .IsUnique();
        }
    }
}
