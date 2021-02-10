using System;
using System.ComponentModel.DataAnnotations;

namespace SQL_Models
{
    public class Salesman
    {
        [Key]
        public int Salesman_id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Commision { get; set; }
    }
}
