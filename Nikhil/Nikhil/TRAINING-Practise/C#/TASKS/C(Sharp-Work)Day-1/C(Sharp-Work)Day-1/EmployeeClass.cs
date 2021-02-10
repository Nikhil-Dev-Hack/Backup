using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_Day_1
{
   public class EmployeeClass
    {
        public void Execute()
        {
            EmpolyeesDetails empolyeesDetails = new EmpolyeesDetails();
            Console.WriteLine("Enter Person Id");
            empolyeesDetails.PersonId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter FirstName");
            empolyeesDetails.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            empolyeesDetails.LastName = Console.ReadLine();
            Console.WriteLine("Enter Basic");
            empolyeesDetails.Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter HRA");
            empolyeesDetails.HRA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter OtherAllowences");
            empolyeesDetails.OtherAllowences = Convert.ToInt32(Console.ReadLine());
            PrintDetails(empolyeesDetails);
        }

        private void PrintDetails(EmpolyeesDetails empolyeesDetails)
        {
            Console.WriteLine("Below are the EmployeeDetails");
            Console.WriteLine($"Person id: {empolyeesDetails.PersonId}, \n FirstName: {empolyeesDetails.FirstName},\n LastName: {empolyeesDetails.LastName}, \n TotalSalary: {empolyeesDetails.Basic + empolyeesDetails.HRA + empolyeesDetails.OtherAllowences} \n");
        }
    }
}
