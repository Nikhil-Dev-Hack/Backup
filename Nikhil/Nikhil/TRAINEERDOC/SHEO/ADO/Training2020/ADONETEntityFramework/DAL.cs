using ADONETEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ADONETEntityFramework
{
    public class DAL
    {

        

        public void List()
        {
            using(Training2020DbContext context = new Training2020DbContext())
            {
                var employees = context.Employees.Where(d=>d.Name.StartsWith("S"));

                foreach(var employee in employees)
                {
                    Console.WriteLine(employee.AutoId + " | " + employee.Name + " | " + employee.Location);
                }
            }
        }

        public void ListDepartments()
        {
            using (Training2020DbContext context = new Training2020DbContext())
            {
                var departments = context.Departments;

                foreach (var department in departments)
                {
                    Console.WriteLine(department.DepartmentId + " | " + department.Name);
                }
            }
        }

        public void AddDepartment(string departmentName)
        {
            using (Training2020DbContext context = new Training2020DbContext())
            {
                Department department = new Department()
                {
                    Name = departmentName
                };

                context.Departments.Add(department);
                context.SaveChanges();
            }
        }
        
        public void UpdateDepartment(int departmentId, string newDepartmentName)
        {
            using (Training2020DbContext context = new Training2020DbContext())
            {
                //var department = context.Departments.Find(departmentId);

                var department = context.Departments.Where(d => d.DepartmentId == departmentId).FirstOrDefault();
                if (department != null)
                {
                    department.Name = newDepartmentName;
                    context.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }                
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            using (Training2020DbContext context = new Training2020DbContext())
            {
                var department = context.Departments.Where(d => d.DepartmentId == departmentId).FirstOrDefault();
                if (department != null)
                {
                    context.Departments.Remove(department);
                    context.SaveChanges();
                }
            }
        }

        public void ListWithJoins()
        {
            using(Training2020DbContext context = new Training2020DbContext())
            {
                var data = from employee in context.Employees
                           join department in context.Departments
                           on employee.DepartmentId equals department.DepartmentId
                           select new
                           {
                               EmpId = employee.EmpId,
                               EmployeeName = employee.Name,
                               DepartmentName = department.Name
                           };

                foreach(var item in data)
                {
                    Console.WriteLine(item.EmpId + " | " + item.EmployeeName + " | " + item.DepartmentName);
                }
            }
        }





    }
}
