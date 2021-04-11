using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Payments
{
    class CreditCard : NubankCard
    {
        public override void Validade()
        {
            Console.WriteLine("Validando limite..");
            Console.WriteLine("Limite OK");
        }
    }
}
