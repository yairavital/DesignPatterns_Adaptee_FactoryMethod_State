using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Cool : Emojy
    {
        private string color;
        public Cool(int position,string color) : base(position)
        {
            this.color = color;
        }
    }
}
