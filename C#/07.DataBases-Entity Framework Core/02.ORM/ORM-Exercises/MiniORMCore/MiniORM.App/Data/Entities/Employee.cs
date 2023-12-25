using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.App.Data.Entities
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public bool IsEmployed { get; set; }

        [ForeignKey(nameof(Departments))]
        public int DepartmentId { get; set; }

        public Departments Departments { get; set; }
        public ICollection<EmployeesProject> EmployeesProject { get; }

    }
}
