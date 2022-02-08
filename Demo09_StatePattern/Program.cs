using System;

namespace Demo09_StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Ganpat University");

            account.Deposit(20000.00);
            account.Deposit(7000.00);
            account.Deposit(85000.00);
            account.Withdraw(90000.00);
            account.Withdraw(2000.00);
        }
    }
}
