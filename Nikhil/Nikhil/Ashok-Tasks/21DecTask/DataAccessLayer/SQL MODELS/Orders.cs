using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Orders
    {
        [Key]
        public int Order_no { get; set; }
        public decimal Purchase_amt { get; set; }
        public DateTime Order_date { get; set; }
        public int Customer_id { get; set; }
        public int Salesman_id { get; set; }

        public ICollection<Salesman> Salesmen { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
