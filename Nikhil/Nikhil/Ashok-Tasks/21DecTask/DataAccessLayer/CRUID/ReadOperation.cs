
using System;


namespace DataAccessLayer.CRUID
{
    public class ReadOperation
    {
        public void Read()
        {
            using (CompanyContext context = new CompanyContext())
            {
                var Customers = context.Customers;

                foreach (var item in Customers)
                {
                    Console.WriteLine(item.Customer_Name + "||" + item.City + "||" + item.Grade + "||" + item.Orders + "||" + item.Salesmen);
                }

            }
        }
    }
}
