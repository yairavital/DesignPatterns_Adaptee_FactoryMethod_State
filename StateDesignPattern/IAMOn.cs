using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal class IAMOn : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("The light is off now.");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("I already on..");
            return this;
        }
    }
}
