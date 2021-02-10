using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.SQL_MODELS
{
    public class Customer
    {
        [Key]
        public int Customer_id { get; set; }
        public Orders Orders { get; set; }
        public string Customer_Name { get; set; }
        public string City { get; set; }
        public string Grade { get; set; }
        public int Salesman_id { get; set; }
        public ICollection<Salesman> Salesmen { get; set; }


    }
}
