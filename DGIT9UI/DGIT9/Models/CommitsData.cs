using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DGIT9.Models
{
    [Table("CommitsData")]
    public class CommitsData
    {
        public string RepoId { get; set; }
        public string CommitId { get; set; }
        public DateTime CommitDate { get; set; }
        [Key]
        public string Email { get; set; }
        public Int64 Adds { get; set; }
        public Int64 Deletes { get; set; }
        public Int64 Edits { get; set; }
        public string UserId { get; set; }
        public string Comments { get; set; }
        public string RemoteUrl { get; set; }
        public string Url { get; set; }
    }
}