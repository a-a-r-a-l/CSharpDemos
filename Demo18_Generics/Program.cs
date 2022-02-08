using System;

namespace Demo18_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            MyGenericType<int> intVariable = new MyGenericType<int>();
            intVariable.Value = 10;
            intVariable.DisplayInfo();

            MyGenericType<string> strVariable = new MyGenericType<string>();
            strVariable.Value = "hello world";
            strVariable.DisplayInfo();

            MyGenericType<Employee> empVariable = new MyGenericType<Employee>();
            empVariable.Value = new Employee() { 
                EmployeeId = 10, 
                EmployeeName = "First Employee" 
            };
            empVariable.DisplayInfo();
        }
    }
}
