using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole
{
    class StackDemo
    {
        public void Execute()
        {
            Stack myBucket = new Stack();
            myBucket.Push(1);
            myBucket.Push("Two");
            myBucket.Push(3.0);
            ShowStackItems(myBucket);
            Console.WriteLine($"The top most item in the stack is: {myBucket.Peek()}");
            Console.WriteLine($"Popping item from stack, and it is: {myBucket.Pop()}");
            ShowStackItems(myBucket);
        }

        private void ShowStackItems(Stack myBucket)
        {
            foreach (var item in myBucket)
            {
                Console.WriteLine(item);
            }
        }
    }
}
