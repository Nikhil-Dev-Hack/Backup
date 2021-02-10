using Microsoft.SqlServer.Server;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessAccessLayer;
using DesignPatterns;

namespace NTierArchitecture
{
    class Program
    {

        static void Main(string[] args)
        {

            Factory factory = new Factory();
            var village = factory.GetPeople(PeopleType.RURAL);
            Console.WriteLine(village.GetName());

            var city = factory.GetPeople(PeopleType.URBAN);
            Console.WriteLine(city.GetName());


            //SingleTon singleTon = SingleTon.Instance;

            //var sum = singleTon.Sum(2, 3);
            //Console.WriteLine(sum);

            //SingleTon singleTon1 = SingleTon.Instance;
            //sum = singleTon1.Sum(4, 3);
            //Console.WriteLine(sum);

            //SingleTon singleTon2 = SingleTon.Instance;
            //sum = singleTon2.Sum(8, 3);
            //Console.WriteLine(sum);


            return;
            Console.WriteLine("Enter EmpId to see the details:");
            var empId = Console.ReadLine().ToString();
            DataSet dataSet = new DataSet();
            try
            {
                dataSet = new EmployeeAddressDetails().GetEmployeeAddressDetails(empId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured. " + ex.ToString());
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine(row["EmpId"] + " | " + row["Name"] + " | " + row["Salary"]);
            }

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                Console.WriteLine(row["Address1"] + " | " + row["Address2"] + " | " + row["City"]);
            }
        }


    }
}
