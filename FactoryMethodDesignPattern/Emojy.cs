using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal abstract class  Emojy
    {
       public int Position { get; set; }
        public Emojy(int position)
        {
            Position = position;
        }
    }
}
