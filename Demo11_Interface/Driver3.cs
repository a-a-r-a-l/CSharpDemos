using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Interface
{
    interface IVehicle
    { 
        void Drive();
    }

    class Driver3
    {
        public void Drive(IVehicle objVehicle)
        {
            Console.WriteLine("---- Driver is now driving a vehicle - using the Interface");
            objVehicle.Drive();
        }
    }
}
