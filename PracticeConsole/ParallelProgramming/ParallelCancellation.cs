using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole.ParallelProgramming
{
    public class ParallelCancellation
    {
        public void Execute()
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = Environment.ProcessorCount;
            po.CancellationToken = cts.Token;

            Task.Factory.StartNew(() => {
                if (Console.ReadKey().KeyChar == 'c')
                    cts.Cancel();
            });

            try
            {
                var employees = Get_10Lakh_Employees();
                Parallel.ForEach(employees, po, (emp) => {
                    Console.WriteLine($"Emp no: {emp.EmpNo}\tEmp name: {emp.EmpName}\tSalary: {emp.Salary}");
                });
                po.CancellationToken.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException oce)
            {
                Console.WriteLine(oce.Message);
                //throw;
            }
        }

        private List<Employee> Get_10Lakh_Employees()
        {
            Random rnd = new Random(100000);
            var employees = new List<Employee>();
            for (int i = 0; i < 1000000; i++)
            {
                int randomNumber = rnd.Next(100000, 9999999);
                employees.Add(new Employee
                {
                    EmpNo = randomNumber,
                    EmpName = $"Employee {randomNumber}",
                    Salary= randomNumber
                });
            }
            return employees;
        }
    }
}
