using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_Interface
{
    // Demo of Boxing and Unboxing
    class Driver2
    {
        public void Drive(object objVehicle)                // boxing
        {
            Console.WriteLine("---- Driver is driving a vehicle");
            if(objVehicle is Car)                           // type checking
            {
                Car objCar = objVehicle as Car;             // unboxing type casting
                objCar.DriveCar();
            }
            else if (objVehicle is Scooter)
            {
                Scooter objScooter = objVehicle as Scooter;
                objScooter.DriveScooter();
            }
        }

    }
}
