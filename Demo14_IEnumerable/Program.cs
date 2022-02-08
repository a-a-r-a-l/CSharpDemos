using System;

namespace Demo14_IEnumerable
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
            Console.WriteLine("--- Listing Employees using IEnumerable interface implementation");
            foreach(Employee emp in company)
            {
                Console.WriteLine("{0} {1}", emp.EmployeeId, emp.EmployeeName);
            }

        }
    }
}
