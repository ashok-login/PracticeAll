using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class TaskClassExample01
    {
        public void Execute()
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task task1 = new Task(PrintCounter);
            task1.Start();
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has completed");
            Console.ReadKey();
        }

        private void PrintCounter()
        {
            Console.WriteLine($"Child Thread {Thread.CurrentThread.ManagedThreadId} has started");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Current iteration: {i} ");
            }
            Console.WriteLine($"Child Thread {Thread.CurrentThread.ManagedThreadId} has completed");
        }
    }
}
