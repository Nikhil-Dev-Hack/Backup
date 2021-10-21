using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleAppAzureDevops.Data
{
    class CommitsData
    {
        public string RepoId { get; set;}
        public string Id { get; set; }
        public string CommitId { get; set; }
        public DateTime CommitDate { get; set; }
        public string Adds { get; set; }
        public string Deletes { get; set; }
        public string Edits { get; set; }
        public string UserId { get; set; }

    }
}
