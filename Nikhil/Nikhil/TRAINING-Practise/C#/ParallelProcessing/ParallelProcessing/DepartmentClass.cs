using System;
using System.Threading.Tasks;

namespace ParallelProcessing
{
    public class DepartmentClass
    {
        public void ShowAllDepartments()
        {
            //Method method = new Method();
            var Department = new Method().GetAll();
            Console.WriteLine("Printing all the values using ParallelForEach");

            Parallel.ForEach(Department, (dept) =>
            {

                Console.WriteLine($"Dept id: {dept.DepartmentID}\t Dept name: {dept.DepartmentName}\t Location: {dept.Location}");
            });

            Console.WriteLine("Printing all the values using ParallelFor");
            Parallel.For(0, Department.Count, (indexcount) =>
            {
                var dept = Department[indexcount];


                Console.WriteLine($"Dept id: {dept.DepartmentID}\t Dept name: {dept.DepartmentName}\t Location: {dept.Location}");
            });
        }



    }
}
