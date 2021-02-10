using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public string EmpId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Mobile { get; set; }

        public string Gender { get; set; }

        public string Location { get; set; }

        public DateTime JoiningDate { get; set; }

        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }

        public int? DepartmentId { get; set; }

    }
}
