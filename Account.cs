using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPBank
{
    public class Account
    {
        const decimal MIN_BAL = 1000;
        public readonly string AccNo;
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            private set { if (value >= MIN_BAL) _balance = value; }
        }

        public Account(string accNo, decimal amount) 
        { 
            this.AccNo = accNo;
            this.Balance = amount;
        }

        public void Deposit(decimal amount) 
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
