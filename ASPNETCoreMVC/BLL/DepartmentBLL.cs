using ASPNETCoreMVC.BLL.Contracts;
using ASPNETCoreMVC.DAL;
using ASPNETCoreMVC.DAL.Contracts;
using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.BLL
{
    public class DepartmentBLL : IDepartmentBLL
    {
        private readonly IDepartmentDAL _dal;

        public DepartmentBLL(IDepartmentDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }
        public bool DeleteDepartment(int id)
        {
            return _dal.DeleteDepartment(id);
        }

        public List<Department> GetAll()
        {
            return _dal.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _dal.GetDepartmentById(id);
        }

        public bool SaveDepartment(Department department)
        {
            if(department.Id < 0)
            {
                throw new Exception("Department number cannot be negative");
            }
            if(department.DeptName.Trim().Length <= 2)
            {
                throw new Exception("Department name is too short");
            }
            if(department.Loc.Trim().Length <= 2)
            {
                throw new Exception("Department location is too short");
            }
            return _dal.SaveDepartment(department);
        }
    }
}
