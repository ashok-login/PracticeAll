using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.ParallelProgramming
{
    public class ParallelExample02
    {
        public void Execute()
        {
            var list = new ConcurrentBag<string>();
            string[] directoryNames = { @"D:\Ashok", @"D:\Office" };
            var timer = Stopwatch.StartNew();
            timer.Start();
            foreach (var directory in directoryNames)
            {
                string[] paths = Directory.GetFiles(directory);
                foreach (var path in paths)
                {
                    list.Add(path);
                }
            }
            list.Clear();
            timer.Stop();
            Console.WriteLine($"Took { timer.ElapsedMilliseconds } milliseconds time to read all files from both the directories");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            timer.Start();
            Parallel.ForEach(directoryNames, (currentDirectory) => {
                string[] paths = Directory.GetFiles(currentDirectory);
                foreach (var path in paths)
                {
                    list.Add(path);
                }
            });
            timer.Stop();
            Console.WriteLine($"Parallel.ForEach took { timer.ElapsedMilliseconds } milliseconds time to read all files from both the directories");
        }
    }
}
