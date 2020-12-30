using PracticeConsole.EFCF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.EFCF
{
    public class UpdateDepartment02_DisconnectedScenario
    {
        public void UpdateDepartment(int id)
        {
            Department dept;
            using (var context = new CompanyContext())
            {
                dept = context.Departments.Find(id);
                dept.DeptName = "Accounting";
                context.Entry(dept).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Execute()
        {
            var id = 1;
            UpdateDepartment(id);
            Console.WriteLine("Record updated successfully.");
        }
    }
}
