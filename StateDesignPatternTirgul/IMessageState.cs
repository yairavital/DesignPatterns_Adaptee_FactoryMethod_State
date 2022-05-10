using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTirgul
{
    internal interface IMessageState
    {
        public IMessageState SendMessage();
        public IMessageState MoveToArchieve();
        public IMessageState RemoveFromArchieve();
    }
}
