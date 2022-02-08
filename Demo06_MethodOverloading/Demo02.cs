using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_MethodOverloading
{
    class Demo02
    {
        // Demo of Boxing and Unboxing
        public void DoSomething(object o)
        {
            if (o is int)               // IS OPERATOR - type checking
            {
                int i = (int)o;         // unboxing
                Console.WriteLine("Received integer: {0}", i);
            }
            else if (o is bool)
            {
                bool b = (bool)o;
                Console.WriteLine("Received Boolean: {0}", b);
            }
        }
    }
}
