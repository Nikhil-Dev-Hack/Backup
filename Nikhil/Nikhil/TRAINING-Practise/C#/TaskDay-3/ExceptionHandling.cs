using System;

namespace C_Sharp_Work_.TaskDay_3
{
    public class ExceptionHandling
    {
        public void Execute()
        {
            Employee employee = new Employee();
            try
            {
                Console.WriteLine("Enter emp number");
                employee.EmpNo = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Enter emp name");
                employee.FirstName = (Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Enter emp salary");
                employee.Salary = int.Parse(Console.ReadLine());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Enter Department name");
                employee.DeptName = (Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
