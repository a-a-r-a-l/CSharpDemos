using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_Delegate
{
    delegate int ComputeHandler(int a, int b);

    class Calculator
    {
        public int Compute(int a, int b, ComputeHandler objD)
        {
            int result = -1;

            Console.WriteLine("--- 5 Steps of Encapsulation");
            Console.WriteLine(" 1. Authentication");
            Console.WriteLine(" 2. Authorization");

            Console.WriteLine(" 3. Validation");
            if (objD != null)
            { 
                Console.WriteLine(" 4. The Process / Activity");
                result = objD(a, b);
            }

            Console.WriteLine(" 5. Audit Logging");

            return result;
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("--- 5 Steps of Encapsulation");
            Console.WriteLine(" 1. Authentication");
            Console.WriteLine(" 2. Authorization");
            Console.WriteLine(" 3. Validation");
            Console.WriteLine(" 4. The Process / Activity");
            Console.WriteLine(" 5. Audit Logging");

            return a + b;
        }

    }
}
