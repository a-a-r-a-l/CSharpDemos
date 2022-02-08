using System;

namespace Demo11_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Overloaded methods");
            Demo01();
            Console.WriteLine();

            Console.WriteLine("Demo of Boxing and Unboxing");
            Demo02();
            Console.WriteLine();

            Console.WriteLine("Demo using Interface");
            Demo03();
            Console.WriteLine();
        }

        static void Demo01()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver1 objDriver = new Driver1();

            objDriver.Drive(objCar);
            objDriver.Drive(objScooter);

        }

        static void Demo02()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver2 objDriver = new Driver2();

            objDriver.Drive(objCar);
            objDriver.Drive(objScooter);

        }


        static void Demo03()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver3 objDriver = new Driver3();

            objDriver.Drive(objCar);
            objDriver.Drive(objScooter);

        }

    }
}
