using System;

namespace ADO_DAY_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // new InsertADO().Insert();
            //new RetriveTheTable().Reader();
            //new ShowDetailsByParameter().ReadEmployeeByID("TP01");
            new GetEmployeeDetailsByName().ReadEmployeeByName("SWAPNA");
            //new DataSetDemo().Execute();
        }

    }
}
