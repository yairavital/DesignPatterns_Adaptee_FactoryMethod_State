using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTirgul
{
    internal class IamSend : IMessageState
    {
        public IMessageState MoveToArchieve()
        {
            Console.WriteLine("You cant move  to archieve because the message is already send ");
            return this;

        }

      public  IMessageState SendMessage()
        {
            Console.WriteLine("You already send this message ");
            return this;
        }
        public IMessageState RemoveFromArchieve()
        {
            Console.WriteLine("You already send this message it cant be in the archieve ");
            return this;
        }
    }
}
