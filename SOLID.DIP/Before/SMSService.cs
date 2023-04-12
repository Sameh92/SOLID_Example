using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Before
{
    internal class SMSService
    {
        public string MobileNo { get; set; }

        public void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}
