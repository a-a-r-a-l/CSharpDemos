using System;

namespace Demo13_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Microsoft Corp.");
            company.AddEmployee("Bill Gates");
            company.AddEmployee("Steve Jobs");

            company.DisplayEmployees();

            Console.WriteLine();
            Console.WriteLine("--- Listing Employees using IEnumerator interface implementation");

            company.Reset();
            while (company.MoveNext())
            {
                Employee emp = company.Current as Employee;
                Console.WriteLine("{0} {1}", emp.EmployeeId, emp.EmployeeName);
            }

        }
    }
}
