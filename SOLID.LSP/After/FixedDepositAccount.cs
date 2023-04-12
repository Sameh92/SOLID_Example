using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.After
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

       
    }
}
