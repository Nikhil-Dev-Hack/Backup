using System;
using System.Reflection;

namespace ADONETEntityFramework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Entity Framework Demo!");

            // new DAL().List();

            Console.WriteLine("*************List Departments ******************");
            // new DAL().AddDepartment("ADO.NET Department");
            // new DAL().UpdateDepartment(16, "Entity Framework Core Department");
            // new DAL().DeleteDepartment(16);
            // new DAL().ListDepartments();

            new DAL().ListWithJoins();
        }

        private static void ListData()
        {
            
        }
    }
}
