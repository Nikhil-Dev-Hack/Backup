using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRACTISE.PARALLEL_PROGRAMING
{
    public class PARALLELPROGRAMINGEXAMPLE
    {
        public void DeapartmentClass()
        {
            var Department = new MethodForParallel().GetInfo();
            Console.WriteLine("Printing using ParallelFor");

            Parallel.For(0, Department.Count, (indexcount) =>
             {
                 var dept = Department[indexcount];

                 Console.WriteLine($"DepartmentId:{dept.DepartmentId}\t DeptName: {dept.DepartmentName}\t Location:{dept.Location}");
             });
        }
    }
}
