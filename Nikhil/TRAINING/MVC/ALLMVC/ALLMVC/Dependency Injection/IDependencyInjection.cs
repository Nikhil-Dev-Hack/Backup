using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALLMVC.Dependency_Injection
{
    public interface IDependencyInjection
    {
        string GetMyAge(DateTime dateTime);
    }
}
