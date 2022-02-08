using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo01
{
    public class Demo
    {
        static public void Run()
        {
            Employee emp = new Employee("First Employee");
            Console.WriteLine("{0}", emp.Name);
        }
    }

    class Employee
    {
        // Construtor
        // Initalize all internal instance member
        public Employee(string name)
        {
            _name = name;
        }


        // backing field
        private string _name;

        // Readonly Property (only get is there)
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
