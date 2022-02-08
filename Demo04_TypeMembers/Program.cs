using System;

namespace Demo04_TypeMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string AUTHOR = "Manoj Kumar Sharma";

            Console.WriteLine("Author = {0}", AUTHOR);


            MyDayNames day = MyDayNames.Thursday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);
            day = MyDayNames.Sunday;
            Console.WriteLine("{0} : int = {1}", day, (int)day);

            int i = 5;
            day = (MyDayNames)i;
            Console.WriteLine("{0} {1}", day, i);

            MyStructure objStructure;
            objStructure.ID = 20;
            objStructure.Name = "";

            MyClass obj = new MyClass();                // Instantiation is compulsory
            obj.ID = 10;
            obj.Name = "First object";


            MyClass o;                  // Declaration
            o = new MyClass();          // Instantiation
            o.ID = 30;                  // Initialization
            o.Name = "Something";       // Initiatlization

        }
    }
}
