using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Before
{
    internal class FixedDepositAccount:Account
    {
        public FixedDepositAccount(string name, decimal balance) : base(name, balance)
        {

        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotImplementedException($"you can not withdraw from Fixed Deposit Account");
        }
    }
}
