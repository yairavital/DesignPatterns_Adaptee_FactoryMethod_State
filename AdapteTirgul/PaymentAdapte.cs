using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgul
{
    internal class PaymentAdapte: EuroPayment
    {
        private DollarPaycs adapte;
        public void Payment(double payCust)
        {
            adapte.Payment(payCust * 1.05);
        }  
    }
}
