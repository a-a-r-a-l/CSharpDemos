using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface_Extending.Demo02
{
    interface IDemo
    {
        void p();
    }

    interface IAnotherDemo
    {
        void p();
        void q();
    }

    class Demo : IDemo, IAnotherDemo
    {
        // explicit implementation of the interface signature
        void IDemo.p()
        {
        }

        // explicit implementation of the Interface signature
        void IAnotherDemo.p()
        {
        }


        // implicit implementation of the interface signature
        public void q()
        {
        }
    }
}
