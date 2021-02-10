using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer.Context
{
    public class EmployeeBaseProgram
    {
        public string _ConnStr = string.Empty;

        public IList<Employee> EmployeeMethod()
        {
            _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            System.Data.DataTable table = new System.Data.DataTable();
            using (SqlConnection connection = new SqlConnection(_ConnStr))
            {
                var Sql = "SELECT * FROM Employees";

                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(command))
                    {
                        adp.Fill(table);
                    }
                }
            }

            IList<Employee> employees = new List<Employee>();

            foreach (DataRow row in table.Rows)
            {
                var Employee = new Employee()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Salary = decimal.Parse(row["Salary"].ToString()),
                    DeptId = int.Parse(row["DeptId"].ToString())
                };

                employees.Add(Employee);
            }

            return employees;

        }

    }
}
