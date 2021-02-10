using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelProcessing
{
    public class Method
    {
        public List<DepartmentDetails> GetAll()
        {
            var Department = new List<DepartmentDetails>();
            Console.WriteLine(" Enter the Value");
            var g = int.Parse(Console.ReadLine());
            for (int i = 0; i < g; i++)
            {
                Random rd = new Random();
                var value = rd.Next();
                var dept = new DepartmentDetails
                {

                    DepartmentID = int.Parse(Console.ReadLine()),
                    DepartmentName = Console.ReadLine(),
                    Location = Console.ReadLine()
                };
                Department.Add(dept);
            }
            return Department;
        }
    }
}
