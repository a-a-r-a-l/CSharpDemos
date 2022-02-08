using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo04
{
    class Person
    {
        // Instance member (belongs to the object)
        public readonly int ID;
        public readonly string Name;

        // Type member (shared amongst all objects of the class)
        static private int counter;

        // Type Constructor
        // used to initialize type member
        static Person()
        {
            Person.counter = 0;
        }

        // Instance Constructor
        // used to initialize instance members
        public Person(string name)
        {
            this.ID = ++Person.counter;
            this.Name = name;
        }
    }
}
