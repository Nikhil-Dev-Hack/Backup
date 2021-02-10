using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Configuration;


namespace ADO_DAY_1_
{
    public class CreateADO
    {
        private string connectionString;
        private SqlConnection objconn;

        public CreateADO()
        {
            connectionString = "Data Source=192.168.50.95;Initial Catalog=nbanuri;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            objconn = new SqlConnection(connectionString);
            objconn.Open();
            if (objconn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection is established successfullly...");
            }
            else
            {
                Console.WriteLine("Connection is not established");
                objconn.Close();
            }

        }

        public void Run()
        {

        }

    }
}
