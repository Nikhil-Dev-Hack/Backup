using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class TaskCreation_Handling_With_Types
    {
        public void TaskNormal()
        {
            Task task = new Task(Method);
            task.Start();
            task.Wait();
            //Console.ReadKey();

        }
        
        public void TaskRun()
        {
            Task task = Task.Run(() =>
            {
                Method();
            });
            task.Wait();
        }

        public void TaskPooling()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                Method();   
            });
            task.Wait();
        }

        public void GenericTask()
        {
            Task<int> task = Task.Factory.StartNew(() =>
            {
                return CalculateSum(10);
               
            });
            Console.WriteLine(task.Result);
        }

        private int CalculateSum(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }

        public void Method()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("You are being executed by Task");
            }
        }
    }
}
