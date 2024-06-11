using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPBank
{
    internal class AccountTransferService
    {
        public static void Transfer(Account fromAcc, Account toAcc, decimal amount)
        {
            fromAcc.Withdraw(amount);
            toAcc.Deposit(amount);
        }
    }
}
