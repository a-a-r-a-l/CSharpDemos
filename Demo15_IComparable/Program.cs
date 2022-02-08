using System;

namespace Demo15_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] theEmployees = new Employee[5];

            theEmployees[0] = new Employee();
            theEmployees[0].EmployeeID = 1;
            theEmployees[0].EmployeeName = "First Employee";
            theEmployees[0].Salary = 1000000M;

            // Object Initializer
            theEmployees[1] = new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Second Employee",
                Salary = 200000M
            };

            theEmployees[2] = new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "Third Employee",
                Salary = 250000M
            };

            theEmployees[3] = new Employee()
            {
                EmployeeID = 4,
                EmployeeName = "Fourth Employee",
                Salary = 250000M
            };

            theEmployees[4] = new Employee()
            {
                EmployeeID = 5,
                EmployeeName = "Fifth Employee",
                Salary = 180000M
            };


            Console.WriteLine("--- List of Employees:");
            foreach (Employee emp in theEmployees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", emp.EmployeeID, emp.EmployeeName, emp.Salary);
            }
            Console.WriteLine();

            Array.Sort(theEmployees);

            Console.WriteLine("--- List of Employees AFTER SORTING:");
            foreach (Employee emp in theEmployees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", emp.EmployeeID, emp.EmployeeName, emp.Salary);
            }
            Console.WriteLine();

        }
    }
}
