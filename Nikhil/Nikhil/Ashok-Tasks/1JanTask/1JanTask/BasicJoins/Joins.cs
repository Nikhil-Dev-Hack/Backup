using _1JanTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1JanTask.BasicJoins
{
    public class Joins
    {
        public void Joinswithlinq()
        {
            var employeesByDepartment = Department.GetAllDepartments().GroupJoin(Employee.GetAllEmployees(),
                                                                             d => d.ID,
                                                                             e => e.DepartmentID,
                                                                             (department, employees) => new
                                                                             {
                                                                                 Department = department,
                                                                                 Employees = employees
                                                                             });

            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
