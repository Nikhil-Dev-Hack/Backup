namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {

            #region FileCreation
            FileCreation file = new FileCreation();
            //file.FilesNormal();
            file.FilesUsing();
            //file.UsingFinally();
            #endregion

            #region ThreadCreation&Handling-With-Types
            //ThreadCreation_Handling_With_Types threadCreation = new ThreadCreation_Handling_With_Types();
            //threadCreation.ThreadNormal();
            //threadCreation.ThreadAnoy();
            //threadCreation.ThreadLambda();
            #endregion

            #region TaskCreation&Handling-With-Types
            //TaskCreation_Handling_With_Types taskCreation = new TaskCreation_Handling_With_Types();
            //taskCreation.TaskNormal();
            //taskCreation.TaskRun();
            //taskCreation.TaskPooling();
            //taskCreation.GenericTask();
            #endregion


            #region Timer


            #endregion


            #region PrallelProcessing

            #endregion
        }




    }
}
