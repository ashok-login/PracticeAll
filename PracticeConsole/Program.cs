using PracticeConsole.EFCF;
using PracticeConsole.ExtensionMethods;
using PracticeConsole.ParallelProgramming;
using System;

namespace PracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //new GetCurrentExecutingMethodDemo().CurrentMethod();
            //new StackDemo().Execute();
            //new ThreadingDemo().Execute();
            //new Test().Execute();
            //new AsyncDemo().Execute();
            //new AsyncDemo2().Execute();
            //new TaskClassExample01().Execute();
            //new TaskClassExample02().Execute();
            //new TaskClassExample03().Execute();
            //new TaskClassExample04().Execute();
            //new TaskClassExample05().Execute();
            //new ParallelForEachDemo().Execute();
            //new TransactionsDemo().Execute();
            //new ParallelExample01().Execute();
            //new ParallelExample02().Execute();
            //new ParallelCancellation().Execute();
            //new ArrayListParallelFor().Execute();
            //new ADONETTransactionDemo().Execute();
            //new AddNewDepartmentUsingEFCF().Execute();
            //new FindAge().Execute();
            //new UpdateDepartment01_ConnectedScenario().Execute();
            new UpdateDepartment02_DisconnectedScenario().Execute();
            Console.ReadKey();
        }
    }
}
