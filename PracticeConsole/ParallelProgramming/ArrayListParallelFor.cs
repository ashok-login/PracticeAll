using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.ParallelProgramming
{
    public class ArrayListParallelFor
    {
        public void Execute()
        {
            var hashTable = new Hashtable();
            hashTable.Add("1", "One");
            hashTable.Add("2", "Two");
            hashTable.Add("3", "Three");

            //foreach (var key in hashTable.Keys)
            //{
            //    Console.WriteLine(key + ", " + hashTable[key]);
            //}
            ConcurrentDictionary<string, string> cache = new ConcurrentDictionary<string, string>();
        }
    }
}
