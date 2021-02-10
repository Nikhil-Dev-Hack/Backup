using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTISE.PARALLEL_PROGRAMING
{
    public class MethodForParallel
    {
        public List<DepartmentForPrallel> GetInfo()
        {
            var Department = new List<DepartmentForPrallel>();
            Console.WriteLine("Enter the value");
            var f = int.Parse(Console.ReadLine());
            for (int i = 0; i < f; i++)
            {
                Random rd = new Random();
                var value = rd.Next();
                var dept = new DepartmentForPrallel
                {
                    DepartmentId = int.Parse(Console.ReadLine()),
                    DepartmentName = Console.ReadLine(),
                    Location = Console.ReadLine()
                    
                };
                Department.Add(dept);
            }
            return Department;
        }
    }
}
