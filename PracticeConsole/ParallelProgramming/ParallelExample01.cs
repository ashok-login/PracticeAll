using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.ParallelProgramming
{
    /// <summary>
    /// This example shows that for simple operations, Parallel.For won't be that much helpful
    /// </summary>
    public class ParallelExample01
    {
        public void Execute()
        {
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 1; i < 100; i++)
            {
                var forLoopResult = DoSomeOperation();
            }
            timer.Stop();
            Console.WriteLine($"for loop took { timer.ElapsedMilliseconds } milliseconds");

            var po = new ParallelOptions()
            {
                MaxDegreeOfParallelism = Environment.ProcessorCount
            };

            timer.Start();
            Parallel.For(1, 100, po, (i) => { DoSomeOperation(); });
            timer.Stop();
            Console.WriteLine($"Parallel.For took { timer.ElapsedMilliseconds } milliseconds");
        }

        private int DoSomeOperation()
        {
            int maxLimit = 1000000;
            int sum = 0;
            for (int i = 1; i <= maxLimit; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
