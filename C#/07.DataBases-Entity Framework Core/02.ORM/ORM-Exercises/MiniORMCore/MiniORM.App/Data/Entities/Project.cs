using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.App.Data.Entities
{
    internal class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        ICollection<EmployeesProject> EmployeesProject { get; }

    }
}
