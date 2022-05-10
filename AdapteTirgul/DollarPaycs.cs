using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgul
{
    internal class DollarPaycs
    {
        public int priceDollar;
        public DollarPaycs()
        {
            priceDollar = 50;

        }
        public void Payment(int payDollar)
        {
            Console.WriteLine($"The products cost {priceDollar} Dollars \n The customer gave {payDollar}" +
                $"\n The surplus is {payDollar-priceDollar} ");
        }
    }
}
