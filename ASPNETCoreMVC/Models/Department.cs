using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC.Models
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Loc { get; set; }
    }
}
