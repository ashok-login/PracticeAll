using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace PracticeConsole
{
    class GetCurrentExecutingMethodDemo
    {
        public void CurrentMethod()
        {
            try
            {
                throw new Exception("Unexpected error occurred.");
            }
            catch (Exception ex)
            {
                var stackTrace = ex.StackTrace;
                //var currentClass = this.GetType().Name;
                var currentClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                var currentMethod = new StackTrace().GetFrame(0).GetMethod().Name;
                var lineNumber = new StackFrame(0, true).GetFileLineNumber();
                Console.WriteLine($"Current class: {currentClass},\nCurrent method: {currentMethod},\nLine number: {lineNumber},\nStack trace: {stackTrace}");
            }
        }
    }
}
