using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_ExtensionMethods
{
    static class MyExtensions
    {
        // How to prepare an extension method
        // 1. The class has to be a Singleton (mark the class as a "static" class.
        // 2. Ensure that the Object to be extended is the FIRST PARAMETER
        // 3. Ensure the FIRST PARAMETER is decorated with the "this" keyword
        public static int Multiply(this Calculator objCalc, int a, int b)
        {
            return a * b;
        }
        
        public static int Divide(this Calculator objCalc, int a, int b)
        {
            Console.WriteLine("Divide() in Extension method executed!");
            return a / b;
        }

        public static void DisplayAuthor(this object o)
        {
            Console.WriteLine("Manoj Kumar Sharma");
        }
    }
}
