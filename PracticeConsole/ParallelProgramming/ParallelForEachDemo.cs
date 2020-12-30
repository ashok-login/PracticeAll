using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.ParallelProgramming
{
    public class ParallelForEachDemo
    {
        public void Execute()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    EmpNo = 1001,
                    EmpName = "Employee 1",
                    Salary = 100000
                },
                new Employee
                {
                    EmpNo = 1002,
                    EmpName = "Employee 2",
                    Salary = 100001
                },
                new Employee
                {
                    EmpNo = 1003,
                    EmpName = "Employee 3",
                    Salary = 100002
                }
            };
            Console.WriteLine("Employee details using foreach loop");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.EmpNo}\t{emp.EmpName}\t{emp.Salary}");
            }
            Console.WriteLine("Employee details using Parallel.ForEach loop:");
            Parallel.ForEach(employees, (emp) =>
            {
                Console.WriteLine($"{emp.EmpNo}\t{emp.EmpName}\t{emp.Salary}");
            });
            Console.WriteLine("Employee details using Parallel.For loop");
            Parallel.For(0, employees.Count, (empIndex) => {
                var emp = employees[empIndex];
                Console.WriteLine($"{emp.EmpNo}\t{emp.EmpName}\t{emp.Salary}");
            });
        }
    }
}
