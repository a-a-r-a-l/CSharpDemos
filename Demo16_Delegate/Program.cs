using System;

namespace Demo16_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo02();
        }

        static void Demo02()
        {
            Calculator calc = new Calculator();

            int result;
            result = calc.Add(10, 20);
            Console.WriteLine("Sum of 10 and 20 = {0}", result);

            Console.WriteLine();
            result = Program.Multiply(10, 20);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            Console.WriteLine("Calling the method using the delegate:");
            result = calc.Compute(10, 20, Program.Multiply);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Demo01()
        {
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver objDriver = new Driver();

            objDriver.Drive(objCar.DriveCar);
            objDriver.Drive(objScooter.DriveScooter);
        }
    }
}
