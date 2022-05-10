using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTirgul
{
    internal class BeforSend : IMessageState
    {
        public IMessageState MoveToArchieve()
        {
            Console.WriteLine("The message is in the archieve now");
            return new IamArchieve();
        }

        public IMessageState SendMessage()
        {
            Console.WriteLine("the message was sent successfully");
            return new IamSend();
        }
        public IMessageState RemoveFromArchieve()
        {
            Console.WriteLine("This message cant remove from the archieve because it dont exit their ");
            return this;
            }
    }
}
