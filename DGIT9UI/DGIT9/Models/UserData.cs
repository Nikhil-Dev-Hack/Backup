using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DGIT9.Models
{
    [Table("UserData")]
    public class UserData
    {   [Key]
        public Int64 Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }

}