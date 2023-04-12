using System;

namespace TightlyVsLooselyCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NotificationService notificationService = new NotificationService(new EmailService(),new SMSService());
            // NotificationService notificationService = new NotificationService(new EmailService());
            // var serviceMode = NotifcactionModeFactory.Create(NotificationMode.SMS);
            var serviceMode = NotifcactionModeFactory.Create(NotificationMode.HYBRID);
            NotificationService notificationService = new NotificationService(serviceMode);

            notificationService.Notify();
            Console.ReadKey();

        }
    }
    class NotifcactionModeFactory
    {
        public static INotificationMode Create(NotificationMode mode)
        {
            INotificationMode Mode = mode switch
            {
                NotificationMode.EMAIL => new EmailService(),
                NotificationMode.SMS => new SMSService(),
                NotificationMode.HYBRID=>new HybridServices(),
                _ => null

            };


           return Mode;
        }
    }
    enum NotificationMode
    {
        EMAIL,
        SMS,
        HYBRID
    }
    /* Tight Coupling Below
    -------------------------
    public class EmailService
    {

        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
    
    public class SMSService
    {
      
        public void Send()
        {
            Console.WriteLine("SMS Sent");

        }
    }

    public class NotificationService
    {
        private readonly EmailService _emailService;
        private readonly SMSService _smsService;
        public NotificationService(EmailService emailService, SMSService smsService)
        {
            _emailService = emailService;
            _smsService = smsService;
        }
        public void Notify()
        {
            _emailService.Send();
            _smsService.Send();

        }
    }*/

    /* Loose Coupling Below
    -------------------------
    */
    public interface INotificationMode
    {
        void Send();
    }
    public class EmailService:INotificationMode
    {

        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
    public class SMSService: INotificationMode
    {
      
        public void Send()
        {
            Console.WriteLine("SMS Sent");
         
        }
    }
    public class HybridServices : INotificationMode
    {

        public void Send()
        {
            Console.WriteLine("Hybrid Sent");
        }
    }

    public class NotificationService
    {
        private readonly INotificationMode _notificationMode;
      
        public NotificationService(INotificationMode notificationMode)
        {
            _notificationMode = notificationMode;
            
        }
        public void Notify()
        {
            _notificationMode.Send();

        }
    }
}
