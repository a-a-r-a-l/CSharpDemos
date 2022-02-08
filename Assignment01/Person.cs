using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Person
    {
        private string _name;

        public string Name
        {
            // GET ACCESSOR
            get
            {
                return _name;
            }
            // SET ACCESSOR
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    _name = value;
                }
            }
        }

        // Backing Data Field
        private int _age;

        // Property
        public int Age
        {
            // GET ACCESSOR
            get
            {
                return _age;
            }
            // SET ACCESSOR
            set
            {
                if (value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age has to be 18 and 65");
                }
            }
        }

    }
}
