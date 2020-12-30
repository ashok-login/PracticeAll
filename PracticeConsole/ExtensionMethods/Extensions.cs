using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.ExtensionMethods
{
    public static class Extensions
    {
        public static int Age(this DateTime dateOfBirth)
        {
            var ageInYears = DateTime.Today.Year - dateOfBirth.Year;
            if(dateOfBirth.AddYears(ageInYears) > DateTime.Today)
            {
                ageInYears--;
            }
            return ageInYears;
        }
    }
}
