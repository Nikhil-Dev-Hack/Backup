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
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        [DataType(DataType.Currency)]
        public decimal EmpSalary { get; set; }

        [Column("city")]
        public string City { get; set; }

        [DataType(DataType.Currency)]
        public decimal NetSalary { get; set; }


    }
}
