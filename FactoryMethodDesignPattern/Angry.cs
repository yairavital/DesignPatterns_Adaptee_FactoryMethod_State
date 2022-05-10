using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class Angry : Emojy
    {
        private string redStrenght;
        public Angry(int position, string redMode) : base(position)
        {
            redStrenght = redMode;
        }
    }
}
