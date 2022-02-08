using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Interface
{
    class Scooter : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Scooter is being driven");
        }

        public void DriveScooter()
        {
            Console.WriteLine("Scooter is being driven");
        }
    }
}
