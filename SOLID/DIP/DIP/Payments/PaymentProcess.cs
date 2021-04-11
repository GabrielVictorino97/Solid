using DIP.Factory;
using DIP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
