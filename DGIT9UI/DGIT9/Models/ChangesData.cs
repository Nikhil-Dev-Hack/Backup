using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DGIT9.Models
{
   
    public class ChangesData
    {
        [Key]
        public string CommitId { get; set; }
        public string RepoId { get; set; }
        public string ObjectId { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string Chnagetype { get; set; }//spell
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 AutoId { get; set; }

    }
}