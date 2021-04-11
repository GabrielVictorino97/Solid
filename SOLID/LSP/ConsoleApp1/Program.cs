using ConsoleApp1.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            NubankRewards card = new NubankRewards();

            card.Validade();
            card.CollectPayment();

            Console.ReadLine();

        }
    }
}
