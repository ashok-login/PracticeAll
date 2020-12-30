using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.DAL.Contracts
{
    public interface IDepartmentDAL
    {
        bool SaveDepartment(Department department);
        bool DeleteDepartment(int id);
        List<Department> GetAll();
        Department GetDepartmentById(int id);
    }
}
