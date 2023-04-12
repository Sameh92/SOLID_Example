using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.After
{
    // Low Level Module
    internal class EmailService:IMessageService
    {
        public string EmailAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"e-email is sent to {EmailAddress}");
        }
    }
}
