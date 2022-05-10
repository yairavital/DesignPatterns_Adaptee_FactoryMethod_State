using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal class Context
    {
        private ILightState state;

        public Context(ILightState state)
        {
            this.state = state;
        }
        public void TurnOnRequest()
        {
            this.state= state.TurnOn();

        }
        public void TurnOffRequest()
        {

            this.state = state.TurnOff();

        }
    }
}
