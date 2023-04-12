using System;

namespace SOLIDSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWithSRP();
            Console.ReadKey();
        }

        private static void TestWithoutSRP()
        {
            var account = new Before.Account("samehR", "samehR@test.com", 10000);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }
        private static void TestWithSRP()
        {
            var account = new After.Account("samehR", "samehR@test.com", 10000);
            var accountService = new After.AccountService();
            accountService.Deposit(account,500);
            accountService.Withdraw(account,11000);

        }
    }
}
