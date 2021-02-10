using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALLMVC.Dependency_Injection
{
    public class DependencyInjection : IDependencyInjection
    {
        public string GetMyAge(DateTime dateTime)
        {
            var val = DateTime.Now.Subtract(dateTime);
            DateTime age = DateTime.MinValue + val;
            return string.Format("{0}Years {1} monhs {2} Days", age.Year - 1, age.Month - 1, age.Day - 1);
        }
    }
}
