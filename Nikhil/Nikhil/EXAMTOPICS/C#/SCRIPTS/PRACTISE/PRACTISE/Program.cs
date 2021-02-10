using PRACTISE.FILES;
using PRACTISE.OOPS;
using PRACTISE.PARALLEL_PROGRAMING;
using PRACTISE.PROPERTIES_WITH_EXCEPTION_HANDLING;
using PRACTISE.THREADING;
using System;

namespace PRACTISE
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ParallelFor&ParallelEach
            PARALLELPROGRAMINGSYNTAX pARALLELPROGRAMING = new PARALLELPROGRAMINGSYNTAX();
            //pARALLELPROGRAMING.ParallelFor();
            //pARALLELPROGRAMING.ParallelForeach();
            #endregion

            #region ParallelExample
            PARALLELPROGRAMINGEXAMPLE pARALLELPROGRAMINGEXAMPLE = new PARALLELPROGRAMINGEXAMPLE();
            //pARALLELPROGRAMINGEXAMPLE.DeapartmentClass();
            #endregion

            #region THREADINGSYSNTAX
            THREADINGSYSNTAX tHREADINGSYSNTAX = new THREADINGSYSNTAX();
            //tHREADINGSYSNTAX.ThreadNormal();
            //tHREADINGSYSNTAX.ThreadAnoy();
            //tHREADINGSYSNTAX.ThreadLambda();
            #endregion

            #region TASKSYNTAX
            TASKSYNTAX tASKSYNTAX = new TASKSYNTAX();
            //tASKSYNTAX.TaskNormal();
            //tASKSYNTAX.TaskRun();
            //tASKSYNTAX.TaskPooling();
            //tASKSYNTAX.GenericTask();
            #endregion

            #region ThreadingExample
            //new THREADINGEXAMPLE().TicketCancelation();
            #endregion

            #region FileCreation
            FILESSYNTAX fILESSYNTAX = new FILESSYNTAX();
            //fILESSYNTAX.NormalFiles();
            //fILESSYNTAX.FilesUsing();
            //fILESSYNTAX.UsingFinally();
            #endregion
            #region OVERRIDING
            OVERLOADING over = new OVERLOADING();
            //System.Console.WriteLine(over.MethodOverLoading(20));
            //System.Console.WriteLine(over.MethodOverLoading("Hell"));
            #endregion

            #region OVERLOADING
            OVERRIDING riding = new OVERRIDING();
            //Console.WriteLine(riding.MethodOverLoading("Hell"));
            #endregion

            #region PROPERTIES-WITH-EXCEPTION_HANDLING
            ERRORHANDLING er = new ERRORHANDLING();
            //er.Execute();
            #endregion




        }
    }
}
