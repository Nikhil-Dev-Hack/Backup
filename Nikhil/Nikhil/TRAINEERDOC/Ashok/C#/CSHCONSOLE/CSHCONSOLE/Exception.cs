using System;
using System.Collections.Generic;
using System.Text;

namespace CSHCONSOLE
{
    class exception
    {
        public void employee()
        {

           
            try
            {
                Console.WriteLine("Enter employee number should be grater than 1001:");
                int empno = Convert.ToInt32(Console.ReadLine());

                if (empno <= 1001)
                {
                    throw new Exception("empno should be greater then 1001");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }



            try
            {
                Console.WriteLine("Enter employee name with more than 3 charcters:");
                string empname = Console.ReadLine();

                if (empname == null || empname.Length <= 3)
                {
                    throw new Exception("enter valid name");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine("enter the salary");
                int empsal = Convert.ToInt32(Console.ReadLine());
                if (empsal <= 0)
                {
                    throw new Exception("salary should be positive");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("enter dept name");
                string empdept = Console.ReadLine();
                if (empdept != "developer")
                {
                    throw new Exception("enter developer");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
