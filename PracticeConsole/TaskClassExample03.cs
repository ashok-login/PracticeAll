using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class TaskClassExample03
    {
        public void Execute()
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task task1 = Task.Run(() => { PrintCounter(); });
            task1.Wait();
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has ended");
            Console.ReadKey();
        }

        private void PrintCounter()
        {
            Console.WriteLine($"Child Thread {Thread.CurrentThread.ManagedThreadId} has started");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
            Console.WriteLine($"Child Thread {Thread.CurrentThread.ManagedThreadId} has ended");
        }
    }
}
