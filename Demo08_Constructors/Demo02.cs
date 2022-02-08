using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo02
{

    // C# Language Compiler will ADD the default Constructor, Only if developer has not defined any constructor
    class ClassA
    {

    }


    // Developer has added the construct.  C# Language compile will not add anything
    class ClassB
    {
        public ClassB()
        {

        }
    }

    class ClassC
    {
        // Paramterized Constructor 
        public ClassC(int id)
        {

        }
    }

    class ClassD
    {
        // Default Constructor
        public ClassD()
        {

        }

        // Parameterized constructor 
        public ClassD(int id)
        {

        }

    }
}
