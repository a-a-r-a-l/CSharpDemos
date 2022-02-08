using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Indexer
{
    /// <summary>
    ///     Demo of:
    ///     (1) Aggregation (one object inside another - Eg: ArrayList of employees is inside Company object)
    ///     (2) Auto-Implemented Property
    ///     (3) Dynamically resizeable collection (Array  Vs. ArrayList)
    ///     (4) Late-Instantiation Pattern (create an aggregated object only when required)
    ///     (5) Automatically seed the ID of the employee 
    /// </summary>

    class Company
    {
        
        //private string _companyName;            // backup data field
        //public string CompanyName               // property
        //{
        //    get                                 // GET accessor
        //    {
        //        return _companyName;
        //    }
        //    private set                                 // SET accessor
        //    {
        //        _companyName = value;
        //    }
        //}

        // Auto-Implemented Property 
        // C# Language Compiler will generate the backing field, and the above shown Get/Set Accessor 
        public string CompanyName { get; private set; }

        // Aggregated Collection.
        private System.Collections.ArrayList theEmployees { get; set; }
        private int counter;



        public Employee this[int id]
        {
            get
            {
                Employee empRetVal = null;

                foreach(Employee emp in this.theEmployees)
                {
                    if( emp.EmployeeID == id)
                    {
                        empRetVal = emp;
                        break;
                    }
                }

                return empRetVal;
            }
        }

        public Employee this[string name]
        {
            get
            {
                Employee empRetVal = null;

                foreach (Employee emp in this.theEmployees)
                {
                    if (emp.EmployeeName == name)
                    {
                        empRetVal = emp;
                        break;
                    }
                }

                return empRetVal;
            }
        }

        public Company(string name)
        {
            this.CompanyName = name;

            this.theEmployees = null;                   // Late-Instantiation Pattern
            this.counter = 0;
        }

        public void AddEmployee(string name)
        {
            Employee empNew = new Employee();
            empNew.EmployeeID = ++this.counter; 
            empNew.EmployeeName = name;

            if(this.theEmployees == null)               // check if the Late-Instantiation Collection is NULL
            {
                this.theEmployees = new System.Collections.ArrayList();     // Instantiation
            }

            // add the newly created employee object to the collection.
            this.theEmployees.Add(empNew);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("--- List of employees of {0}", this.CompanyName);
            foreach(Employee emp in this.theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);
            }
        }
    }
}