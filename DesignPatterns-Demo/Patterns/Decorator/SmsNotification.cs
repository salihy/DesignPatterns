using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Decorator
{
    public class SmsNotification : INotification
    {
        private INotification _notification;

        public SmsNotification(INotification notification)
        {
            _notification = notification;
        }
        public async Task notify()
        {
            await _notification.notify();

            Console.WriteLine("Sms Notif Sent!");
        }
    }
}
