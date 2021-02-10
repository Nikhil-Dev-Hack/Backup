using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CRUID
{
    public class ReadOPeration
    {
        public void Read()
        {
            using (CompanyContext context = new CompanyContext())
            {
                var Customers = context.Customers;

                foreach (var item in Customers)
                {
                    Console.WriteLine(item.Customer_Name + "||" + item.City + "||" + item.Grade + "||" + item.Salesman_id);
                }

            }
        }
    }
}
