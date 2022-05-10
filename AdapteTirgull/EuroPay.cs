using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgull
{
    internal class EuroPay : InEuroPay
    {
        public void Payment(double pay)
        {
            Console.WriteLine($"You pay {pay} Euros");
        }
    }
}
