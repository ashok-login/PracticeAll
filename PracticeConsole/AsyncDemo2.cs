using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class AsyncDemo2
    {
        public void Execute()
        {
            Task t = Task.Run(() =>
            {
                Calculate1();
            });
            t = Task.Run(() =>
            {
                Calculate2();
            });
            t = Task.Run(() =>
            {
                Calculate3();
            });
            t.Wait();
        }

        private void Calculate3()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculate3 - 2000 - " + 20 + 30);
        }

        private void Calculate2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Calculate2 - 1000 - " + 20 * 30);
        }

        private void Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calculate1 - 3000 - " + (float)20 / 30);
        }
    }
}
