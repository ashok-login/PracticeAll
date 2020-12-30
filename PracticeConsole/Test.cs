using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class Test
    {
        public void Execute()
        {
            Task task1 = Task.Run(() =>
            {
                Print1to5With2SecsDelay();
            });

            Task task2 = Task.Run(() =>
            {
                Print1to5With2SecsDelay();
            });
            Task task3 = Task.Run(() =>
            {
                Print1to5With2SecsDelay();
            });
            task3.Wait();
            Console.WriteLine("All tasks have completed");
            Console.ReadKey();
        }

        private void Print1to5With3SecsDelay()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"With 3 seconds delay: {i}");
                Thread.Sleep(3000);
            }
        }

        private void Print1to5With1SecDelay()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"With 1 second delay: {i}");
                Thread.Sleep(1000);
            }
        }

        private void Print1to5With2SecsDelay()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"With 2 seconds delay: {i}");
                Thread.Sleep(2000);
            }
        }
    }
}
