using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ADONETEntityFramework.Models
{
    
    public class Employee
    {
        [Key]
        public string EmpId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Mobile { get; set; }

        public string Gender { get; set; }
        public string Location { get; set; }

        public DateTime JoiningDate { get; set; }

        public int? DepartmentId { get; set; }

    }
}
