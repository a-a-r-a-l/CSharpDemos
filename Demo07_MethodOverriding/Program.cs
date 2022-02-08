using System;

namespace Demo07_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo objDemo = new Demo();
            objDemo.DoSomthing();
            Console.WriteLine();

            AnotherDemo objAnotherDemo = new AnotherDemo();
            objAnotherDemo.DoSomthing();
            Console.WriteLine();


            // Object of the Base Type, with behaviours coming from the Derived Type
            Demo objDemo2 = new AnotherDemo();
            objDemo2.DoSomthing();
        }
    }
}
