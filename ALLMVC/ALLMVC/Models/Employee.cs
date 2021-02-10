using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ALLMVC.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


    }
}
