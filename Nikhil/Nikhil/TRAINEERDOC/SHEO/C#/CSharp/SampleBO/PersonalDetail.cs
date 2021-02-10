using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleBO
{
    public class PersonalDetail
    {
        protected internal int AutoId { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public bool Active{ get; set; }
    }
}
