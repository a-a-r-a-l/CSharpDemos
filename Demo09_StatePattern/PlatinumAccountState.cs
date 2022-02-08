using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_StatePattern
{
    class PlatinumAccountState
        : AccountState
    {
        public PlatinumAccountState(AccountState state)
            : this(state.Balance, state.Account)
        {

        }

        public PlatinumAccountState(double balance, BankAccount account)
        {
            base.balance = balance;
            base.Account = account;
            base.upperLimit = double.MaxValue;
            base.lowerLimit = 100000.00;
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
                base.account.State = new GoldAccountState(base.balance, account);
            }
        }
    }
}
