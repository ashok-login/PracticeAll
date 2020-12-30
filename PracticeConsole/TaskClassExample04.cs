using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class TaskClassExample04
    {
        public void Execute()
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has started");
            Task<int> task1 = Task.Run(() => { return CalculateSum(10); });
            Console.WriteLine($"Sum is: {task1.Result}");
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId} has completed");
            Console.ReadKey();
        }

        private Task<int> CalculateSum(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            return Task.FromResult(sum);
        }
    }
}
