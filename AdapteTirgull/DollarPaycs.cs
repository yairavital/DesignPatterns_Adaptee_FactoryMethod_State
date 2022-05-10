using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteTirgull
{
    internal class DollarPaycs:IDollarPaycs
    {
        public void Payment(int pay)
        {
            Console.WriteLine($"You pay {pay} dollars");
        }

 
    }
}
