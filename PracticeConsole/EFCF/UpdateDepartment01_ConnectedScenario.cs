using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeConsole.EFCF
{
    public class UpdateDepartment01_ConnectedScenario
    {
        public void UpdateDepartment(int id)
        {
            using (var context = new CompanyContext())
            {
                var dept = context.Departments.Find(id);
                dept.DeptName = "Accounting Department";
                context.SaveChanges();
                Console.WriteLine("Record updated successfully..");
            }
        }

        public void Execute()
        {
            var id = 1;
            UpdateDepartment(id);
        }
    }
}
