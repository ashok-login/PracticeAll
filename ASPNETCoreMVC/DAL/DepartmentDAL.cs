using ASPNETCoreMVC.DAL.Contracts;
using ASPNETCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.DAL
{
    public class DepartmentDAL : IDepartmentDAL
    {
        private readonly CompanyContext _context;

        public DepartmentDAL(CompanyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool DeleteDepartment(int id)
        {
            try
            {
                var deptToDelete = _context.Departments.Find(id);
                _context.Entry<Department>(deptToDelete).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.Find(id);
        }

        public bool SaveDepartment(Department department)
        {
            var recordToUpdate = _context.Departments.Find(department.Id);
            try
            {
                using (_context)
                {
                    if(recordToUpdate != null)
                    {
                        recordToUpdate.DeptName = department.DeptName;
                        recordToUpdate.Loc = department.Loc;
                        _context.Update(recordToUpdate);
                    }
                    else
                    {
                        _context.Departments.Add(department);
                    }
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
