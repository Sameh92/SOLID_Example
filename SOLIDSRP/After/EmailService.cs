using SOLIDSRP.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSRP
{
    internal class EmailService
    {
        public void Send(Account account,string transactionMessage,DateTime transactionDate)
        {
            Console.WriteLine(
         $"\n\n\t\t To: {account.Email}" +
         $"\n\t\t Subject: Fake Bank Acount Activity" +
         $"\n\n\t\t Dear {account.Name}," +
         $"\n\n\t\t a recent Activity on your account occures at {transactionDate}" +
         "\n\t\t\t\t ===>{0}" +
         $"\n\n\t\t Thank You ,\n\t\t Fake Bank." +
         $"\n\n\t\t ---------------------------", transactionMessage);
        }
    }
}
