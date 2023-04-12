using System;
using System.Collections.Generic;

namespace SOLID.DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var customers = Before.Repository.Customers;
            //foreach(var customer in customers)
            //{
            //    var notificationService= new Before.NotificationService(customer);
            //    notificationService.Notify();
            //}

            var customers = After.Repository.Customers;
            foreach (var customer in customers)
            {
                var messageServie = new List<After.IMessageService>
                {
                    new After.EmailService{EmailAddress=customer.EmailAddress},
                    new After.SMSService{MobileNo=customer.MobileNo},

                    //New Service
                    new After.MailBoxService{Address=customer.Address}
                };

                // constructor Injection
                var notificationService = new After.NotificationService(messageServie);// here Dependency Injection
             //   notificationService.Notify();


                // property Injection
                var notificationServiceproperty = new After.NotificationServiceProperty();// here Dependency Injection
                notificationServiceproperty.SetServices(messageServie);
              //  notificationService.Notify();


                // method Incjection
                var notificationServiceMethod = new After.NotificationServiceMethod();// here Dependency Injection
                notificationServiceMethod.Notify(messageServie);
            }
            Console.ReadKey();
        }
    }
}
