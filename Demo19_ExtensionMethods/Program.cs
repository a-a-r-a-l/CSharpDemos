using System;

namespace Demo19_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;

            result = objCalc.Add(10, 20);
            Console.WriteLine("Sum of {0} and {1} =  {2}", 10, 20, result);
            Console.WriteLine();

            Console.WriteLine("--- Calling the method directly from the Static Singleton Class");
            result = MyExtensions.Multiply(objCalc, 20, 30);
            Console.WriteLine("Product = {0}", result);

            Console.WriteLine("---- Calling it using the Extension method");
            result = objCalc.Multiply(20, 30);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            result = objCalc.Divide(10, 2);
            Console.WriteLine("Result of Divide: {0}", result);
            Console.WriteLine();

            int i = 1;
            i.DisplayAuthor();
            result.DisplayAuthor();

        }
    }
}
