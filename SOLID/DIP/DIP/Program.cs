using DIP.Payments;
using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("Abc123");

            Console.ReadLine();
        }
    }
}
