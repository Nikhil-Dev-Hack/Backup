using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_2_
{
    public class RetriveTheTable
    {
        static string _connStr = string.Empty;

        public void Reader()
        {
            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                using (SqlCommand cmd = new SqlCommand("ShowAllEmployeeDetails",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(reader.GetOrdinal("DepartmentID")) + reader.GetString("EmployeeName") + reader.GetString("Email")+ reader.GetInt64("MobileNumber") + reader.GetDecimal("Salary") );
                        }
                    }
                }
                
            }
        }
    }
}
