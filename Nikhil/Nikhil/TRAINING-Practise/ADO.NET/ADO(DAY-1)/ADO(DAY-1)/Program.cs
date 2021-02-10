using System;

namespace ADO_DAY_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creating Connection with sql server
            //new CreateADO().Run();
            #endregion

            #region Retrive into Sql server
            //new RetriveADO().NewADOConnection();
            #endregion 

            #region Insert into sql server
            new InsertADO().Run();
            #endregion
        }
    }
}
