using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Decorator
{
    public class BaseNotification : INotification
    {
        private INotification _notification;

        public BaseNotification()
        {
            
        }

        public BaseNotification(INotification notification)
        {
            _notification = notification;
        }
        public async Task notify()
        {
            if (_notification != null)
            {
                await _notification.notify();
            }
            Console.WriteLine("Notification Sent!");
            
        }
    }
}
