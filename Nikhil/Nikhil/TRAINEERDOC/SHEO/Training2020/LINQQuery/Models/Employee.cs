using System;
using System.Collections.Generic;
using System.Text;

namespace LINQQuery.Models
{
    public class Employee
    {

        public string EmpId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Mobile { get; set; }

        public string Gender { get; set; }
        public string Location { get; set; }

        public DateTime JoiningDate { get; set; }

        public int AutoId { get; set; }

        public int? DepartmentId { get; set; }

    }
}
