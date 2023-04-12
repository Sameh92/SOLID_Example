using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSRP.After
{
    internal class AccountService
    {
        public void Deposit(Account account, decimal amount)
        {
            var transactionMessage = "";
            //handle Deposit
            if (amount > 0)
            {
                account.Balance += amount;
                transactionMessage =
                   $" OK Deposit {amount.ToString("C2")} " +
                   $" current balance : {account.Balance.ToString("C2")}";
            }


            EmailService emailService = new EmailService();
            emailService.Send(account, transactionMessage, DateTime.Now);



        }
        public void Withdraw(Account account, decimal amount)
        {
            var transactionMessage = "";

            if (account.Balance < amount)
            {
                transactionMessage =
                    $" OVERDRAFT when trying to withdraw " +
                    $" {Math.Abs(amount).ToString("C2")}," +
                    $" current balance : {account.Balance.ToString("C2")}";
            }
            else
            {
                account.Balance -= amount;
                transactionMessage =
                  $" OK Withdraw {amount.ToString("C2")} " +
                  $" current balance : {account.Balance.ToString("C2")}";
            }

            EmailService emailService = new EmailService();
            emailService.Send(account, transactionMessage, DateTime.Now);
        }

    }
}

