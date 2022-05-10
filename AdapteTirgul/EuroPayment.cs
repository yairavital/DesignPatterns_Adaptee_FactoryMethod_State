using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgul
{
    internal class EuroPayment
    {
        public double priceEuro;
        public EuroPayment()
        {

            priceEuro = 30;
        }

        public void Payment(double euroMoneyCustomer)
        {
            Console.WriteLine($"The products cost {priceEuro} Euro \n The customer gave {euroMoneyCustomer}" +
                $"\n The surplus is {euroMoneyCustomer - priceEuro} ");
        }
    }
}
