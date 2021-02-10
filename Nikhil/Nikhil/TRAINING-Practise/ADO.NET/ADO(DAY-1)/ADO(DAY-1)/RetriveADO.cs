using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_1_
{
    public class RetriveADO
    {
        static string _ConnectionString = string.Empty;

        public void NewADOConnection()
        {

            Console.WriteLine("Which department id records you want to list?");
            var deptId = Console.ReadLine();

            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection connect = new SqlConnection(ConnectionString);

            var sql = "SELECT * FROM employees WHERE department_id = @departmentId ";

            SqlCommand cmd = new SqlCommand(sql, connect);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            try
            {
                connect.Open();


                SqlParameter[] prms = new SqlParameter[1];
                prms[0] = new SqlParameter("@departmentId", SqlDbType.Int);
                prms[0].Value = deptId;

                cmd.Parameters.AddRange(prms);

                adapter.Fill(table);
                connect.Close();

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(row["first_name"] + "|" + row["last_name"] + "|" + row["email"] + "|" + row["phone_number"]);
                }
                connect.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Sorry, an error occured" + ex.ToString());
            }
            finally
            {
                connect.Close();
                table.Dispose();
                adapter.Dispose();
                cmd.Dispose();
               
            }

        }
    }
}
