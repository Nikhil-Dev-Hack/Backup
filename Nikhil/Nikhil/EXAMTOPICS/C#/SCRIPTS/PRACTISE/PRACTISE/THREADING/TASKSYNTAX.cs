using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRACTISE.THREADING
{
    public class TASKSYNTAX
    {
        public void TaskNormal()
        {
            Task task = new Task(Method);
            task.Start();
            task.Wait();
        }

        public void TaskRun()
        {
            Task task = Task.Run(() =>
            {
                Method1();
            }); task.Wait();
        }

        public void TaskPooling()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                Method2();
            }); task.Wait();
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

        private void CalculateSum()
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enter the value");
            var Loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < Loop; i++)
            {
                queue.Enqueue(i);
            }
            foreach (var item in queue)
            {
                Console.WriteLine(item);

            }
        }

        private void Method2()
        {
            SortedSet<int> sortedList = new SortedSet<int>();
            Console.WriteLine("Enter the value");
            var Loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < Loop; i++)
            {
                sortedList.Add(i);
            }
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        private void Method1()
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Enter the value");
            var Loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < Loop; i++)
            {
                arrayList.Add(i);
            }
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        private void Method()
        {
            var Call = new HashSet<int>();
            Console.WriteLine("Enter the value");
            var Loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < Loop; i++)
            {
                //var h = Convert.
                Call.Add(i);

            }
            foreach (var item in Call)
            {
                Console.WriteLine(item);
            }

        }
    }
}
