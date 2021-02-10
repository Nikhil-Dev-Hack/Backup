using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_1_
{
    public class InsertADO
    {
        private string _ConnectionString = string.Empty;
        //private string ConnectionString;
        private SqlConnection objConn;

        public InsertADO()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objConn = new SqlConnection(_ConnectionString);
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Enter Employee firstName ");
                string empfName = Console.ReadLine();
                Console.WriteLine("Enter Employee SecondName");
                string emplName = Console.ReadLine();
                Console.WriteLine("Enter Employees email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Employees phone number");
                string phoneNo = Console.ReadLine();
                //Console.WriteLine("Enter Employee hiredate");
                //int hireDate = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter EmployeeSalary");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employees jobid");
                int jobId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employees ManagerId");
                int managerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employees DepartmentId ");
                int DepartmentId = int.Parse(Console.ReadLine());

                objConn.Open();
                SqlCommand objcmd = new SqlCommand("INSERT INTO employees (first_name,last_name,email,phone_number,job_id,salary,manager_id,department_id) VALUES (@empfNAme,@emplName,@email,@phoneNo,@salary,@jobId,@managerId,@DepartmentId)");
                objcmd.Parameters.AddWithValue("@empfNAme", empfName);
                objcmd.Parameters.AddWithValue("@emplName", emplName);
                objcmd.Parameters.AddWithValue("@email", email);
                objcmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                //objcmd.Parameters.AddWithValue("@hireDate", hireDate);
                objcmd.Parameters.AddWithValue("@salary", salary);
                objcmd.Parameters.AddWithValue("@jobId", jobId);
                objcmd.Parameters.AddWithValue("@managerId", managerId);
                objcmd.Parameters.AddWithValue("@DepartmentId", DepartmentId);
                objcmd.ExecuteNonQuery();
                objConn.Close();



            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occured",ex.ToString());
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                }
            }
            

        }


    }
}
