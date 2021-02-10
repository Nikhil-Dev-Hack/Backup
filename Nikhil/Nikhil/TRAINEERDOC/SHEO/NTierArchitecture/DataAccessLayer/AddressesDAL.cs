using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public class AddressesDAL
    {
        static string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public DataTable FindAddress(string empId)
        {
            // sample internal method use
            var employee = new EmployeeDAL();
            var dataEmp = employee.GetEmployees("", "");

            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string sql = "SELECT * FROM Addresses WHERE EmpId = @empId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(table);
                    }
                }
            }
            return table;
        }
    }
}
