using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Before
{
    internal class NotificationService
    {
        private readonly Customer _customer;
        private readonly EmailService _emailService;
        private readonly SMSService _smssService;
        public NotificationService(Customer customer)
        {
            _emailService = new EmailService()
            {
                EmailAddress = customer.EmailAddress
            };
            _smssService = new SMSService()
            {
                MobileNo = customer.MobileNo,
            };
        }
        public void Notify()
        {
            _emailService.Send();
            _smssService.Send();    
        }
    }
}
