using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Generics
{
    /// <summary>
    ///     Employee Class
    /// </summary>
    class Employee
    {
        /// <summary>
        ///     Gets or Sets the ID of the Employee
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        ///     Gets or Sets the Name of the Employee
        /// </summary>
        public string EmployeeName { get; set; }


        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}", this.EmployeeId, this.EmployeeName);
        }
    }
}
