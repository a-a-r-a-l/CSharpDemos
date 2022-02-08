using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_Delegate
{

    // 1. Define the Delegate
    //    Defines the signature of the method to call, without defining the name of the method
    delegate void DriveHandler();

    class Driver
    {
        // 2. Method which will receive the pointer to method to be called / invoked.
        public void Drive(DriveHandler objD)
        {
            Console.WriteLine("Driver is now driving the vehicle using the reference of the method to call!");

            // 3. if the delegate is pointing to a method
            if(objD != null)
            {
                // 4. invoke the method
                objD();
            }
        }

    }
}
