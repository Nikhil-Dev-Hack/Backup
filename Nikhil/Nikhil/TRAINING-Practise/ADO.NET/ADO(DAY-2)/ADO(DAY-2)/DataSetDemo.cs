using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_2_
{
    public class DataSetDemo
    {
        static string _ConnStr = string.Empty;
        public void Execute()
        {
            DataSet dataSet = new DataSet();

            _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;


            using (SqlConnection connection = new SqlConnection(_ConnStr))
            {
                
                using (SqlCommand cmd = new SqlCommand("DataSetDemo",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(reader.GetOrdinal("DepartmentID")) + reader.GetString("EmployeeName") + reader.GetString("Email") + reader.GetInt64("MobileNumber") + reader.GetDecimal("Salary"));

                        }

                        reader.NextResult();

                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString("DepartmentName")+ "||" + reader.GetString("DepartmentID") );
                        }
                    }
                }
                
                    
                
            }
        }
    }
}
