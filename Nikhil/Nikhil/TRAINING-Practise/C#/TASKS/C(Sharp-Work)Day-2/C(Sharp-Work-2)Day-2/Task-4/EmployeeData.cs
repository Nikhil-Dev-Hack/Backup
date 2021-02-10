using System;
using System.Collections.Generic;

namespace C_Sharp_Work_2_Day_2.Task_4
{
    class EmployeeData
    {

        public void Add()
        {
            List<Employee> employee = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {

                Console.WriteLine($"Enter {i}  employee details");
                Employee employee1 = new Employee
                {

                    DeptName = Console.ReadLine(),
                    EmpNo = int.Parse(Console.ReadLine()),
                    Ename = Console.ReadLine(),
                    salary = int.Parse(Console.ReadLine())
                };
                employee.Add(employee1);
                Outputdisplay(i, employee1);
            }



            //Console.WriteLine("Enter second employee details");
            //Employee employee2 = new Employee
            //{
            //    DeptName = Console.ReadLine(),
            //    EmpNo = int.Parse(Console.ReadLine()),
            //    Ename = Console.ReadLine(),
            //    salary = int.Parse(Console.ReadLine())
            //};
            //Console.WriteLine("Enter third employee details");
            //Employee employee3 = new Employee
            //{
            //    DeptName = Console.ReadLine(),
            //    EmpNo = int.Parse(Console.ReadLine()),
            //    Ename = Console.ReadLine(),
            //    salary = int.Parse(Console.ReadLine())
            //};
            //Console.WriteLine("Enter fourth employee details");
            //Employee employee4 = new Employee
            //{
            //    DeptName = Console.ReadLine(),
            //    EmpNo = int.Parse(Console.ReadLine()),
            //    Ename = Console.ReadLine(),
            //    salary = int.Parse(Console.ReadLine())
            //};
            //Console.WriteLine("Enter fifth employee details");
            //Employee employee5 = new Employee
            //{
            //    DeptName = Console.ReadLine(),
            //    EmpNo = int.Parse(Console.ReadLine()),
            //    Ename = Console.ReadLine(),
            //    salary = int.Parse(Console.ReadLine())
            //};
            //employee.Add();
            //employee.Add(employee2);
            //employee.Add(employee3);
            //employee.Add(employee4);
            //employee.Add(employee5);
        }

        private static void Outputdisplay(int i, Employee employee1)
        {
            if (i == 1)
            {
                DisplayOutput(employee1);
            }
            if (i == 2)
            {
                DisplayOutput(employee1);
            }
            if (i == 3)
            {
                DisplayOutput(employee1);
            }
            if (i == 4)
            {
                DisplayOutput(employee1);
            }
            if (i == 5)
            {
                DisplayOutput(employee1);
            }
        }

        private static void DisplayOutput(Employee employee1)
        {
            Console.WriteLine($"DeptName: {employee1.DeptName}\t ID: {employee1.EmpNo}\t EmpName: {employee1.DeptName}\t Salary: {employee1.salary}");
        }

        //public void ShowAllDepartments()
        //{
        //    Console.WriteLine("Below are available departments");
        //    foreach (var e in employee)
        //    {
        //        Console.WriteLine($"DeptName: {e.DeptName}\t ID: {e.EmpNo}\t EmpName: {e.DeptName}\t Salary: {e.salary}");
        //    }
        //}
    }
}
