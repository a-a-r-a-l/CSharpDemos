using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_StatePattern
{
    abstract class AccountState
    {
        protected BankAccount account;
        protected double balance;
        protected double lowerLimit;
        protected double upperLimit;

        public BankAccount Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }    
        }

        abstract public void Deposit(double amount);
        abstract public void Withdraw(double amount);

    }
}
