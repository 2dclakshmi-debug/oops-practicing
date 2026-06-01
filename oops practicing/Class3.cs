using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practicing
{
    interface IPaymentGateway
    {
        void ProcessPayment();
    }
    class PayPalGateWay:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPalGateWay is Calling");
        }
    }
    class UPIGateWay:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("UPI GateWay is calling ");
        }
    }
    class CreditCardGateWay:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Credit card gateWay is calling");
        }
    }
    class DebitCardGateWay:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("DebitCardGate way is calling");
        }
    }

    internal class Class3
    {
        static void Main(string[] args)
        {
            IPaymentGateway gateway = new PayPalGateWay();
            gateway.ProcessPayment();
            gateway=new UPIGateWay();
            gateway.ProcessPayment();
            gateway=new CreditCardGateWay();
            gateway.ProcessPayment();
            gateway=new DebitCardGateWay();
            gateway.ProcessPayment();
        }
    }
}
