using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class AsyncDemo
    {
        public void Execute()
        {
            Console.WriteLine("Executing AsyncDemo.Execute() method");
            var t = Task.Run(() =>
            {
                Console.WriteLine(AddResult());
            });
            t = Task.Run(() =>
            {
                Console.WriteLine(MultiplicationResult());
            });
            t = Task.Run(() =>
            {
                DivisionResult();
            });
            t.Wait();
        }

        public int AddResult()
        {
            Thread.Sleep(100);
            return 20 + 30;
        }

        public int MultiplicationResult()
        {
            Thread.Sleep(500);
            return 20 * 30;
        }

        public void DivisionResult()
        {
            Console.WriteLine((float)20 / 30);
            Thread.Sleep(3000);
        }
    }
}
