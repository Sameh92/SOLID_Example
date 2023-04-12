using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.After
{
    // new service
    internal class MailBoxService : IMessageService
    {
        public string Address { get; set; }
        public void Send()
        {
            Console.WriteLine($"MailBox  is sent to {Address}");
        }
    }
}
