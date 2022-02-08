using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_StatePattern
{
    class SilverAccountState
        : AccountState
    {
        public SilverAccountState(AccountState state)
            : this(state.Balance, state.Account)
        {

        }

        public SilverAccountState(double balance, BankAccount account)
        {
            base.balance = balance;
            base.Account = account;
            base.upperLimit = 25000.00;
            base.lowerLimit = 0.00;
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
            if (base.balance > base.upperLimit)
            {
                base.account.State = new GoldAccountState(base.balance, account);
            } 
        }

    }
}
