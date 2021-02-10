using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        [ForeignKey("Id")]
        public Department Departments { get; set; }
        
        //public ICollection<Department> Departments { get; set; }

    }
}
