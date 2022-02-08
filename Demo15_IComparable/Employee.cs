using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_IComparable
{
    class Employee
        : System.IComparable
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }

 
        #region System.IComparable interface members 

        public int CompareTo(object obj)
        {
            Employee other = obj as Employee;
            return this.EmployeeName.CompareTo(other.EmployeeName);
        }

        #endregion
    }
}
