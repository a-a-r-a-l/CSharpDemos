using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Interface
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }

        public void DriveCar()
        {
            Console.WriteLine("Car is being driven");
        }

    }
}
