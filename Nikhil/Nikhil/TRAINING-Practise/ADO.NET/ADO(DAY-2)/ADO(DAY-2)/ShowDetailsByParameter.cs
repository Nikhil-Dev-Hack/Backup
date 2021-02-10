using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_2_
{
    public class ShowDetailsByParameter
    {
        static string _connStr = string.Empty;
        public void ReadEmployeeByID(string EmployeeID)
        {
            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (SqlConnection objConn = new SqlConnection(_connStr))
            {
                using (SqlCommand objCmd = new SqlCommand("  SELECT DepartmentID,EmployeeID,EmployeeName,Email,MobileNumber,Salary FROM EmployeeData WHERE EmployeeID = @EmpId",objConn))
                {
                    objCmd.Parameters.AddWithValue("@EmpId", EmployeeID);
                    objConn.Open();
                    using (SqlDataReader objDR = objCmd.ExecuteReader())
                    {
                        if (objDR.Read())
                        {
                            Console.WriteLine($"DepartmentID : {objDR["DepartmentID"]}");
                            Console.WriteLine($"EmployeeID : {objDR["EmployeeID"]}");
                            Console.WriteLine($"EmployeeName : {objDR["EmployeeName"]}");
                            Console.WriteLine($"Email : {objDR["Email"]}");
                            Console.WriteLine($"MobileNumber : {objDR["MobileNumber"]}");
                            Console.WriteLine($"Salary : {objDR["Salary"]}");


                        }
                    }
                }
            }
        }
    }
}
