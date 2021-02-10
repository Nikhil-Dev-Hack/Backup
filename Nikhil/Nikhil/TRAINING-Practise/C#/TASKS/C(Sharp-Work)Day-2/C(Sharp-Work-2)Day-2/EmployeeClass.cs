using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Work_2_Day_2
{
    public  partial class EmployeeDetails
    {
        /// <summary>
        /// Takes Employee details from end user
        /// </summary>
        public void Execute()
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            Console.WriteLine("Enter Person Id");
            employeeDetails.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter FirstName");
            employeeDetails.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            employeeDetails.LastName = Console.ReadLine();
            Console.WriteLine("Enter salary");
            employeeDetails.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DeptName");
            employeeDetails.DeptName = Console.ReadLine();
            PrintDetails(employeeDetails);
        }

        private void PrintDetails(EmployeeDetails employeeDetails)
        {
            Console.WriteLine("Below are the details of employee");
            Console.WriteLine($"Person id: {employeeDetails.EmployeeId}, \n FirstName: {employeeDetails.FirstName},\n LastName: {employeeDetails.LastName}, \n Salary: {employeeDetails.Salary}, \n DeptName: {employeeDetails.DeptName}\n");
        }
    }
}
