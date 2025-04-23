using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesDbApp.DbModel
{
    [Table(name: "Employees")]
    public class Employee
    {
        [Key]
        [Column(name: "EmployeeID")]
        public int EmployeeID { get; set; }

        [MaxLength(50), Column("FirstName"), Required] 
        public required string FirstName { get; set; }

        [MaxLength(50), Column("LastName"), Required] 
        public required string LastName { get; set; }

        [MaxLength(100), Column("Email"), Required]
        public required string Email { get; set; }

        [MaxLength(100), Column(name: "DateOfBirth", TypeName = "date"), Required]
        public required DateOnly DateOfBirth { get; set; }

        [Column(name: "Salary", TypeName = "numeric(18, 2)"), Required]
        public required decimal Salary { get; set; }

        public static Employee CreateDefault() =>
            new Employee() { FirstName = "", LastName = "", DateOfBirth = DateOnly.MinValue, Email = "@", Salary = 0 };
    }
}
