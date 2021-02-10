using LINQQuery.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LINQQuery
{
    class Program
    {
        static string _connStr = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("*** LINQ Examples ***");

            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            var employees = GetEmployees();

            //var data = employees.Where(d => d.Name.Equals("Sravan"));
            // var data = employees.Where(d => d.Name.StartsWith("S"));

            // var data = employees.Where(d => d.Name.StartsWith("S") && d.Gender.Equals("M"));

            // var data = employees.Where(d => d.Gender.Equals("F")).OrderBy(d => d.Name);

            // var data = employees.Where(d => d.Gender.Equals("F")).OrderByDescending(d => d.Name).ThenBy(d=>d.Salary);

            // var data = employees.Where(d => d.Salary > 20000);

            var data = from employee in employees
                       where employee.Salary > 20000
                       select employee;

            foreach (var item in data)
            {
                Console.WriteLine(item.AutoId + " " + item.Name + " " + item.Location + " " + item.Mobile + " "+ item.Gender);
            }

            var totalSalary = employees.Sum(d => d.Salary);
            Console.WriteLine("======== Total Salary: {0} ============", totalSalary);
        }


        private static IList<Employee> GetEmployees()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                var sql = "SELECT * FROM Employees";

                using(SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(command))
                    {
                        ad.Fill(dataTable);
                    }
                }
            }

            IList<Employee> employees = new List<Employee>();
            foreach(DataRow row in dataTable.Rows)
            {
                var employee = new Employee()
                {
                    AutoId = int.Parse(row["AutoID"].ToString()),
                    EmpId = row["EmpId"].ToString(),
                    Gender = row["Gender"].ToString(),
                    JoiningDate = DateTime.Parse(row["JoiningDate"].ToString()),
                    Location = row["Location"].ToString(),
                    Mobile = row["Mobile"].ToString(),
                    Name = row["Name"].ToString(),
                    Salary = decimal.Parse(row["Salary"].ToString())
                };
                employees.Add(employee);
            }

            return employees;
        }

    }
}
