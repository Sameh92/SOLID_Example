using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Before
{
    abstract class Account
    {
        protected Account(string name , decimal balance)
        {
            Name = name;
            Balance= balance;
        }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
}
