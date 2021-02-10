using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SampleDAL;
using SampleBO;
namespace SampleBAL
{
    public class DemoDatabaseBAL
    {
        public DataTable GetData()
        {
            return new DemoDatabaseDAL().GetData();
        }

        
    }
}
