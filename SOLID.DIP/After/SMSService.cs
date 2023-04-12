using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.After
{
    // Low Level Module
    internal class SMSService: IMessageService
    {
        public string MobileNo { get; set; }

        public void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}
