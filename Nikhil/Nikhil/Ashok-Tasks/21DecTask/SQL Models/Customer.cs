using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQL_Models
{
    public class Customer
    {
        [Key]
        public int Customer_id { get; set; }
        public string Cust_Name { get; set; }
        public string City { get; set; }
        public string Grade { get; set; }
        public int Salesman_id { get; set; }
    }
}
