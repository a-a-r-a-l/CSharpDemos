using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_StatePattern
{
    class GoldAccountState
        : AccountState
    {
        public GoldAccountState(AccountState state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldAccountState(double balance, BankAccount account)
        {
            base.balance = balance;
            base.Account = account;
            base.upperLimit = 100000.00;
            base.lowerLimit = 25000.00;
        }

        public override void Deposit(double amount)
        {
            base.balance += amount;
            changeState();
        }

        public override void Withdraw(double amount)
        {
            base.balance -= amount;
            changeState();
        }

        private void changeState()
        { 
            if (base.balance < base.lowerLimit)
            {
                base.account.State = new SilverAccountState(base.balance, account);
            }
            else if (base.balance > base.upperLimit)
            {
                base.account.State = new PlatinumAccountState(base.balance, account);
            }

        }
    }
}
