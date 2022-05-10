using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternTirgul
{
    internal class ContextMessage
    {
        private IMessageState state = new BeforSend();
        public void SendRequest()
        {
            this.state = state.SendMessage();
        }
        public void ArchieveRequest()
        {
            this.state = state.MoveToArchieve();
        }
        public void RemoveFromArchieveRequest()
        {
            this.state = state.RemoveFromArchieve();

        }


    }
}
