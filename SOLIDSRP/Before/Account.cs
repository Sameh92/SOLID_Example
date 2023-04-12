using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSRP.Before
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public Account(string name, string email, decimal balance)
        {
            Name = name;
            Email = email;
            Balance = balance;
        }
        public void MakeTransaction(decimal amount)
        {
            var transactionMessage = "";
            //handle Withdraw
            if (amount < 0)
            {
                if (Balance < Math.Abs(amount))
                {
                    transactionMessage =
                        $" OVERDRAFT when trying to withdraw " +
                        $"{Math.Abs(amount).ToString("C2")}," +
                        $" current balance : {Balance.ToString("C2")}";
                }
                else
                {
                    Balance += amount;//here + because amount is minus 
                    transactionMessage =
                      $" OK Withdraw{amount.ToString("C2")} " +
                      $"current balance : {Balance.ToString("C2")}";
                }
            }
            else
            {  //handle Deposit
                if (amount > 0)
                {
                    Balance += amount;
                    transactionMessage =
                       $" OK Deposit {amount.ToString("C2")} " +
                       $"current balance : {Balance.ToString("C2")}";
                }
            }

            //mock proccess for sending email
            Console.WriteLine(
                $"\n\n\t\t To: {Email}" +
                $"\n\t\t Subject: Fake Bank Acount Activity" +
                $"\n\n\t\t Dear {Name}," +
                $"\n\n\t\t a recent Activity on your account occures at {DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}"+
                "\n\t\t\t\t ===>{0}" +
                $"\n\n\t\t Thank You ,\n\t\t Fake Bank." +
                $"\n\n\t\t ---------------------------", transactionMessage);                
              
        }
    }
}
