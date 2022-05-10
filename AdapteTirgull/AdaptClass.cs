using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgull
{
    internal class AdaptClass: InEuroPay
    {
        private IDollarPaycs dollarConvert = new DollarPaycs();

        public void Payment(double pay)
        {
            pay *= 1.05;
            dollarConvert.Payment((int)pay);
        }
    }
}
