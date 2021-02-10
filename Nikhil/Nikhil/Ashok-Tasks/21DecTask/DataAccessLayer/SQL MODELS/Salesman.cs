using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Salesman
    {
        [Key]
        public int Salesman_id { get; set; }
        public Orders Orders { get; set; }
        public Customer Customer { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Commision { get; set; }

    }
}
