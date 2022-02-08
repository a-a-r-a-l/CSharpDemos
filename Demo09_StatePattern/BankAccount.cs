using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_StatePattern
{
    class BankAccount
    {
        private string AccountHolderName;
        private AccountState _state;

        public BankAccount(string name)
        {
            this.AccountHolderName = name;
            _state = new SilverAccountState(0.0, this);


            Console.WriteLine("Account created for {0}", this.AccountHolderName);
            Console.WriteLine("Balance: {0}", this.Balance);
            Console.WriteLine("Account Status: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public AccountState State
        {
            get
            {
                return _state;
            }
            set 
            {
                _state = value;
            }
        }


        public double Balance
        {
            get
            {
                return this.State.Balance;
            }
        }


        public void Deposit(double amount)
        {
            this.State.Deposit(amount);

            Console.WriteLine("--- Deposited {0}", amount);
            Console.WriteLine("Balance: {0}", this.Balance);
            Console.WriteLine("Account Status: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            this.State.Withdraw(amount);

            Console.WriteLine("--- Withdrawn {0}", amount);
            Console.WriteLine("Balance: {0}", this.Balance);
            Console.WriteLine("Account Status: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}
