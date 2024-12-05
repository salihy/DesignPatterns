using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Decorator
{
    public class TCellSmsNotification : INotification
    {
        private INotification _notification;

        public TCellSmsNotification(INotification notification)
        {
            _notification = notification;
        }
        public async Task notify()
        {
            await _notification.notify();

            Console.WriteLine("TCell Sms Notif. Sent!");
        }
    }
}
