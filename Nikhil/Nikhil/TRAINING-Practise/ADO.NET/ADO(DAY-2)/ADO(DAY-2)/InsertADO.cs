using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO_DAY_2_
{
    public class InsertADO
    {
        static string _ConnStr = string.Empty;

        public void Insert()
        {
            _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            string EmpName, Email, DeptName, EmpNumber;
            int MobileNum, Salary;
            InputMethod(out EmpName, out Email, out MobileNum, out Salary, out DeptName, out EmpNumber);

            using (SqlConnection conn = new SqlConnection(_ConnStr))
            {
                using (SqlCommand command = new SqlCommand("InsertValuesIntoEmployees", conn))
                {
                    SqlParameter[] prms = new SqlParameter[6];
                    prms[0] = new SqlParameter("@empName", SqlDbType.NVarChar, 50);
                    prms[0].Value = EmpName;
                    prms[1] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
                    prms[1].Value = Email;
                    prms[2] = new SqlParameter("@mobileNo", SqlDbType.BigInt);
                    prms[2].Value = MobileNum;
                    prms[3] = new SqlParameter("@salary", SqlDbType.Money);
                    prms[3].Value = Salary;
                    prms[4] = new SqlParameter("@deptName", SqlDbType.VarChar, 50);
                    prms[4].Value = DeptName;
                    prms[5] = new SqlParameter("@EmpId", SqlDbType.VarChar, 50);
                    prms[5].Value = EmpNumber;
                    command.Parameters.AddRange(prms);
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }


        }

        private static void InputMethod(out string EmpName, out string Email, out int MobileNum, out int Salary, out string DeptName, out string EmpNumber)
        {
            Console.WriteLine("Enter Employee Name ");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employees email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter MobileNumber");
            MobileNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Availabe departments are \n1.DTP \n 2.FTP \n 3.HRTP \n 4.");
            DeptName = Console.ReadLine();
            Console.WriteLine("Employee Number Formate Must be TP And Number");
            EmpNumber = Console.ReadLine();
        }
    }
}
