using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_MethodOverriding
{
    class AnotherDemo :  Demo
    {
        public override void DoSomthing()
        {
            Console.WriteLine("DoSomething() called successfully in AnotherDemo");
        }
    }
}
