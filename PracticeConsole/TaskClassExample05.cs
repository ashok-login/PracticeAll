using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class TaskClassExample05
    {
        public void Execute()
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task<int> task1 = Task.Run(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    sum += i;
                }
                return Task.FromResult(sum);
            });
        }
    }
}
