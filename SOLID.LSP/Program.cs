using System;

namespace SOLID.LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Before.FixedDepositAccount("Sameh", 10_000);
            //account.Withdraw(1000);-----> it will throw runtime Error 
            //Console.ReadKey();
            //var account = new After.FixedDepositAccount("Sameh", 10_000);
            //account.Withdraw(1000);----->after apply Liskov the method Withdraw not accessable for fix account

            var account = new After.CheckingAccount("Sameh", 10_000);
            account.Withdraw(1000);
            Console.ReadKey();
        }
    }
}
