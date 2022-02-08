using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_MethodOverriding
{
    // Base Class
    class Demo
    {

        virtual public void DoSomthing()
        {
            Console.WriteLine("DoSomething() in Demo called successfully!");
        }
    }
}
