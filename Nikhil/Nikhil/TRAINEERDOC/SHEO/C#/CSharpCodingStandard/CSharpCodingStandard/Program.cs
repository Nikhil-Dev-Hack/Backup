using System;

namespace CSharpCodingStandard
{

    //======================================
    class Program
    {

        public static void Main()
        {
           //new ParallelProgramming().SimpleParallelLoop();

            new ParallelProgramming().RunMoreThanOneTaskAndWaitForAll();

             //new ParallelProgramming().StoppingParallelProcessingInBetween();

            // new ParallelProgramming().ErrorHandlingInParallelProcessing();

            // new ParallelProgramming().BreakOrStopParallelLoop();  




            ////Statement email = new Statement(new EmailDelivery());
            ////email.SendStatement();

            ////Statement sms = new Statement(new SMSDelivery());
            ////sms.SendStatement();


            //Employee employee = new Employee();
            //employee.Name = null;

            //if (employee is Employee)
            //{
            //    Console.WriteLine("Yes");
            //}


            Console.Read();
        }
    }


    //public interface IDelivery
    //{
    //    void Send();
    //}

    //public class EmailDelivery : IDelivery
    //{
    //    public void Send()
    //    {
    //        // send via email
    //        Console.WriteLine("Email Delivery.");
    //    }
    //}

    //public class SMSDelivery : IDelivery
    //{
    //    public void Send()
    //    {
    //        // send via SMS
    //        Console.WriteLine("SMS Delivery.");
    //    }
    //}

    //public interface IStatement
    //{
    //    void SendStatement();
    //}

    //public class Statement : IStatement
    //{
    //    IDelivery _delivery;
    //    public Statement(IDelivery delivery)
    //    {
    //        _delivery = delivery;
    //    }

    //    public void SendStatement()
    //    {
    //        _delivery.Send();
    //    }
    //}



}
