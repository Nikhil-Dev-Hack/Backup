using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingStandard
{
    [Serializable]
    class Manager
    {
        public virtual string GetName()
        {
            return "Ram";
        }
    }

    class Employee : Manager
    {
        public new string GetName()
        {
            return "Mr. Ram";
        }

        public string Name { get; set; }
    }
}
