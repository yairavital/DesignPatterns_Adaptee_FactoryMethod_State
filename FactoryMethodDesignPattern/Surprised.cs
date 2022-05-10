using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Surprised : Emojy
    { private int surprisedLevel;
        public Surprised(int position,int surprisedLevel) : base(position)
        {
           this.surprisedLevel = surprisedLevel;
        }
    }
}
