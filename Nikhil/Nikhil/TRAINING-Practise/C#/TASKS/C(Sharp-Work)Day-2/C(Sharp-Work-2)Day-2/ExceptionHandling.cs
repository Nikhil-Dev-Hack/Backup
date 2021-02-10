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
                Console.WriteLine("Enter Employee number");
                employee.EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee name");
                employee.FirstName = (Console.ReadLine());
                Console.WriteLine("Enter Employee salary");
                employee.Salary = int.Parse(Console.ReadLine());
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
