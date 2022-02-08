using System;

namespace Demo21_AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result;

            result = calc.Add();
            result = calc.Add(10);
            result = calc.Add(10, 20, 30, 40, 50);

            // Version 2
            result = calc.Compute(100, 200, Program.Multiply);              // implicitly created delegate variable

            // Version 1
            ComputeHandler objD = new ComputeHandler(Program.Multiply);     // explicitly created delegate variable
            result = calc.Compute(100, 200, objD);

            // Anonymous Method
            ComputeHandler objD2 = delegate(int a, int b)
            {
                return a * b;
            };
            result = calc.Compute(100, 200, objD2);

            // LAMBDA Expression
            ComputeHandler objD3 
                = (int a, int b) =>                     // "GOES TO" OPERATOR
                {
                    return a * b;
                };
            result = calc.Compute(100, 200, objD3);

            // LAMBDA Expression
            ComputeHandler objD4
                = ( a, b ) =>                     // "GOES TO" OPERATOR
                {
                    return a * b;
                };
            result = calc.Compute(100, 200, objD4);

            // LAMBDA Expression
            ComputeHandler objD5 = 
                (a, b) => a * b;
            result = calc.Compute(100, 200, objD5);

        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
