using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.After
{

    // High Level Module because it is contain EmailServie and SMSService
    internal class NotificationService
    {

        public readonly List<IMessageService> _services;
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {
            foreach(var service in _services)
            {
                service.Send();
            }
        }
    }

    internal class NotificationServiceProperty
    {
        //Property Injection
        public  List<IMessageService> Services { get; private set; } = new();    
       
        public void SetServices(List<IMessageService> services)
        {
            Services = services;
        }
        public void Notify()
        {
            foreach (var service in Services)
            {
                service.Send();
            }
        }
    }
    internal class NotificationServiceMethod
    {


        //Method Injection
        public void Notify(List<IMessageService> services)
        {
            foreach (var service in services)
            {
                service.Send();
            }
        }
    }
}
