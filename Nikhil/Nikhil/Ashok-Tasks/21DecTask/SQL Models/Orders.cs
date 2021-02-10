using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQL_Models
{
    public class Orders
    {
        [Key]
        public int Order_no { get; set; }
        public decimal Purch_amt { get; set; }
        public DateTime Ord_date { get; set; }
        public int Customer_id { get; set; }
        public int Salesman_id { get; set; }
    }
}
