using System;

namespace Demo10_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Microsoft Corp.");
            company.AddEmployee("Bill Gates");
            company.AddEmployee("Steve Jobs");

            company.DisplayEmployees();

            Employee empFind;

            empFind = company["Bill Gates"];
            if(empFind == null)
            {
                Console.WriteLine("Found Bill Gates in the employees company");
            }
            else
            {
                Console.WriteLine("object was not found in the aggegated collection");
            }


            empFind = company[3];
            if(empFind == null)
            {
                Console.WriteLine("could not find the employee with ID == 3!");
            }
        }


        static void Demo01()
        {
            int[] arr = new int[3] { 10, 20, 30 };

            arr[2] = 300;                   // index of the third element
        }
    }
}
