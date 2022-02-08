using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_IEnumerable
{
    class Company
        : System.Collections.IEnumerable
    {
        private System.Collections.ArrayList theEmployees;
        private int counter;

        public string CompanyName { get; private set; }

        public Company(string companyName)
        {
            this.CompanyName = companyName;

            this.theEmployees = null;
            this.counter = 0;
        }


        #region System.Collections.IEnumerable interface members

        public System.Collections.IEnumerator GetEnumerator()
        {
            if (this.theEmployees != null)
            {
                foreach (Employee emp in this.theEmployees)
                {
                    yield return emp;
                }
            }
            else
            {
                yield break;
            }
        }

        #endregion

        public void AddEmployee(string name)
        {
            Employee emp = new Employee();
            emp.EmployeeId = ++this.counter;
            emp.EmployeeName = name;

            if(this.theEmployees == null)
            {
                this.theEmployees = new System.Collections.ArrayList();
            }
            this.theEmployees.Add(emp);
        }


        public void DisplayEmployees()
        {
            Console.WriteLine("--- Employees of {0}", this.CompanyName);
            foreach(Employee emp in this.theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.EmployeeId, emp.EmployeeName);
            }
        }
    }
}
