using System;

namespace Demo17_MultiCastDelegate
{


    internal class Program
    {

        delegate void ProcessHandler();

        static void Main(string[] args)
        {
            Demo01();

            Demo02();
        }

        static void Demo02()
        {
            Process p1 = new Process();

            ProcessHandler objD1 = new ProcessHandler(p1.Step01);
            objD1 += new ProcessHandler(p1.Step02);
            objD1 += new ProcessHandler(p1.Step05);
            objD1 += new ProcessHandler(p1.Step03);
            objD1 += new ProcessHandler(p1.Step07);
            objD1 += new ProcessHandler(p1.Step09);

            Console.WriteLine("Calling Process #1 using the Multi-Cast Delegate");
            objD1();
            Console.WriteLine();

            ProcessHandler objD2 = new ProcessHandler(p1.Step01);
            objD2 += new ProcessHandler(p1.Step06);
            objD2 += new ProcessHandler(p1.Step10);

            Console.WriteLine("Calling Process #2 using the Multi-Cast Delegate");
            objD2();
            Console.WriteLine();

            Console.WriteLine("transfer control a method, leave it to the method to call the delegated calls");
            Program.DoSomething(objD2);
        }


        static void DoSomething(ProcessHandler objD)
        {
            // check if the delegate is subscribed (check if the delegate is pointing to a method to invoke)
            if (objD != null)
            {
                objD();             // invoke the method
            }
        }
        
        static void Demo01()
        {
            Console.WriteLine("--- Running Process #1");
            Process p1 = new Process();
            p1.Step01();
            p1.Step02();
            p1.Step05();
            p1.Step03();
            p1.Step07();
            p1.Step09();

            Console.WriteLine();
            Console.WriteLine("--- Running Process #2");
            Process p2 = new Process();
            p2.Step01();
            p2.Step06();
            p2.Step10();
        }
    }
}
