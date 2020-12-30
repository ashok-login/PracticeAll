using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.ExtensionMethods
{
    public class FindAge
    {
        public void Execute()
        {
            var dateOfBirth = new DateTime(1978, 7, 9);
            var age = dateOfBirth.Age();
            Console.WriteLine(age);
        }
    }
}
