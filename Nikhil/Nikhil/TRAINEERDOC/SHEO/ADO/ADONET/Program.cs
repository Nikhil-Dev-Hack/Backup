using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Configuration;

namespace ADONET
{
    class Program
    {
        static string _connStr = string.Empty;

        static void Main(string[] args)
        {
            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            Console.WriteLine("ADO.NET Example in .NET Core");
            Console.WriteLine("=============================");

            // List();
            // ListWithSP();

            Insert();

        }

        private static void Insert()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                using (SqlCommand cmd = new SqlCommand("InsertEmployee", conn))
                {
                    SqlParameter[] prms = new SqlParameter[7];
                    prms[0] = new SqlParameter("@empId", SqlDbType.VarChar, 50);
                    prms[0].Value = "PS10";
                    prms[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    prms[1].Value = "Karthik";
                    prms[2] = new SqlParameter("@salary", SqlDbType.Money);
                    prms[2].Value = 25052636.02;
                    prms[3] = new SqlParameter("@mobile", SqlDbType.VarChar, 50);
                    prms[3].Value = "789798797";
                    prms[4] = new SqlParameter("@gender", SqlDbType.VarChar, 50);
                    prms[4].Value = "M";
                    prms[5] = new SqlParameter("@location", SqlDbType.VarChar, 50);
                    prms[5].Value = "Ongole";
                    prms[6] = new SqlParameter("@joiningDate", SqlDbType.Date);
                    prms[6].Value = DateTime.Now;

                    cmd.Parameters.AddRange(prms);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private static void ListWithSP()
        {
            Console.WriteLine("Which department id records you want to list?");
            var deptId = Console.ReadLine();

            //string connStr = "Server=D1DGQLH2;Database=Training2020;User Id=training2020;Password=training2020;";

            // connect to the database
            SqlConnection conn = new SqlConnection(_connStr);

            // create a command to execute
            var sql = "GetEmployeesBasedOnDepartment";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            try
            {
                conn.Open();
                // hold the data retrieved from the database
                // cmd.Parameters.AddWithValue("@departmentId", 2);

                SqlParameter[] prms = new SqlParameter[1];
                prms[0] = new SqlParameter("@departmentId", SqlDbType.Int);
                prms[0].Value = deptId;

                cmd.Parameters.AddRange(prms);
                cmd.CommandType = CommandType.StoredProcedure;
                ad.Fill(table);
                conn.Close();
                // iterate through the table to list the data
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row["EmpId"] + " | " + row["Name"] + " |" + row["Salary"] + row["Gender"]);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an error occured." + ex.Message);
            }
            finally
            {
                // close the connection
                table.Dispose();
                ad.Dispose();
                cmd.Dispose();
                conn.Close();
            }





        }

        private static void List()
        {
            Console.WriteLine("Which department id records you want to list?");
            var deptId = Console.ReadLine();

            //string connStr = "Server=D1DGQLH2;Database=Training2020;User Id=training2020;Password=training2020;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            // connect to the database
            SqlConnection conn = new SqlConnection(connStr);

            // create a command to execute
            var sql = "SELECT * FROM Employees WHERE DepartmentId = @departmentId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            try
            {
                conn.Open();
                // hold the data retrieved from the database
                // cmd.Parameters.AddWithValue("@departmentId", 2);

                SqlParameter[] prms = new SqlParameter[1];
                prms[0] = new SqlParameter("@departmentId", SqlDbType.Int);
                prms[0].Value = deptId;

                cmd.Parameters.AddRange(prms);

                ad.Fill(table);
                conn.Close();
                // iterate through the table to list the data
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row["EmpId"] + " | " + row["Name"] + " |" + row["Salary"] + row["Gender"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an error occured." + ex.Message);
            }
            finally
            {
                // close the connection
                table.Dispose();
                ad.Dispose();
                cmd.Dispose();
                conn.Close();
            }





        }



    }
}
