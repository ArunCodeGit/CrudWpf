using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsmSoftExercises.ApplicationDbContext
{
    public class Department
    {
        int _deptId { get; set; }
        string _deptName { get; set; }

        public int DeptId
        {
            get { return _deptId; }
            set { _deptId = value; }
        }
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        public Department() { }
    }
}
