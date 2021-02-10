using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer.Context
{
    public class DepartmentBaseProgram
    {
        public string _ConnStr = string.Empty;

        public IList<Department> DepartmentMethod()
        {
            _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            System.Data.DataTable table = new System.Data.DataTable();
            using (SqlConnection connection = new SqlConnection(_ConnStr))
            {
                var Sql = "SELECT * FROM Departments";

                using (SqlCommand command = new SqlCommand(Sql, connection))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(command))
                    {
                        adp.Fill(table);
                    }
                }
            }

            IList<Department> departments = new List<Department>();

            foreach (DataRow row in table.Rows)
            {
                var Department = new Department()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Location = row["Location"].ToString()
                };

                departments.Add(Department);
            }

            return departments;

        }

    }
}
