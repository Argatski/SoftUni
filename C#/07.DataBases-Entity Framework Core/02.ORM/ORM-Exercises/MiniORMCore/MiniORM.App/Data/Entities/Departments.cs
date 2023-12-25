using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.App.Data.Entities
{
    internal class Departments
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        ICollection<Employee> Employees { get; }
    }
}
