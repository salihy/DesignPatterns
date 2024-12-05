using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Proxy
{
    public class PaymentGateway : IPayment
    {
        private readonly IPayment _paymentSystem;

        public PaymentGateway(IPayment paymentSystem)
        {
            _paymentSystem = paymentSystem;
        }

        public void pay(double amount)
        {
            _paymentSystem.pay(amount);
        }
    }
}
