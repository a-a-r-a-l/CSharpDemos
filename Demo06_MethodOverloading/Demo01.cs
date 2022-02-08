using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_MethodOverloading
{
    // Demo of Method Overloading
    class Demo01
    {
        public void DoSomething(int i)
        {
            Console.WriteLine("Received integer : {0}", i);
        }


        public void DoSomething(string s)
        {
            Console.WriteLine("Received a string: {0}", s);
        }


        public void DoSomething(bool b)
        {
            Console.WriteLine("Received Boolean: {0}", b);
        }

    }
}
