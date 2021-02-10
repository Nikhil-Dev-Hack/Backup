using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartPortal.Models
{
    public class Cart
    {
        [Key]
        public int ProductId { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public string ProductName { get; set; }

        public string ImageName { get; set; }

    }
}
