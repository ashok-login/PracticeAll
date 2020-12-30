using PracticeConsole.EFCF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.EFCF
{
    public class AddNewDepartmentUsingEFCF
    {
        public void Execute()
        {
            Console.WriteLine("Enter department details to create new record");
            var dept = new Department();
            dept.DeptName = Console.ReadLine();
            dept.Loc = Console.ReadLine();
            using (var dbContext = new CompanyContext())
            {
                dbContext.Departments.Add(dept);
                dbContext.SaveChanges();
            }
        }
    }
}
