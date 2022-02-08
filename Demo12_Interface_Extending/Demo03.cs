using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface_Extending.Demo03
{
    interface IDemo
    {
        void p();
    }

    interface IAnotherDemo : IDemo
    {
        void q();
    }

    // Explicit signature
    class Demo2 : IAnotherDemo
    {
        void IDemo.p()
        {

        }

        void IAnotherDemo.q()
        {

        }
    }

    // implicit implementation of the Interface signatures are applied
    class Demo1 : IAnotherDemo
    {
        public void p()
        {

        }

        public void q()
        {

        }

    }
}
