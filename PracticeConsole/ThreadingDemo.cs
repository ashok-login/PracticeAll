using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class ThreadingDemo
    {
        public void Execute()
        {
            ShowThreadInfo("Application");
            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();
            for (int i = 0; i < 200; i++)
            {
                Console.Write(i + " ");
            }
            t.Wait();
        }

        private void ShowThreadInfo(string s)
        {
            Console.WriteLine(s + " thread id: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
