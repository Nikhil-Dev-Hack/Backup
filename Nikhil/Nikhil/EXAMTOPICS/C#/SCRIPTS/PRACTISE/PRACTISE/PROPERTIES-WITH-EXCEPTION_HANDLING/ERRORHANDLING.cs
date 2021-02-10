using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTISE.PROPERTIES_WITH_EXCEPTION_HANDLING
{
    public class ERRORHANDLING
    {
        public void Execute()
        {

            PROPERTIES prop = new PROPERTIES();
            try
            {
                Console.WriteLine("Enter Employee number");
                prop.EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee name");
                prop.EmpName = (Console.ReadLine());
                Console.WriteLine("Enter Employee salary");
                prop.Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department name");
                prop.DeptName = (Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
