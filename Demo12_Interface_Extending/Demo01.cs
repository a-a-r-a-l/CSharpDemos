using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Interface_Extending.Demo01
{
    interface IDemo
    {
        void p();
    }

    interface IAnotherDemo
    {
        void q();
        void r();
    }

    class Demo : IDemo, IAnotherDemo
    {
        public void p()
        {

        }

        public void q()
        {

        }

        public void r()
        {

        }
    }
}
