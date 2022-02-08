using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_TypeMembers
{

    // Reference Type
    class MyClass
    {
        // Data Field 
        public int ID;

        // public string Name;


        // Backing Data Field
        private string _name;

        // Property
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty.....");
                }
                else
                {
                    _name = value;
                }
            }
        }

    }
}
