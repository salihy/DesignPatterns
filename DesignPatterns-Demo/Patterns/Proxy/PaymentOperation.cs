using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Proxy
{
    public class PaymentOperation : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine("Payment Processed!");
        }
    }
}
