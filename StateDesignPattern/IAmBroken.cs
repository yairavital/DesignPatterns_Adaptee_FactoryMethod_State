namespace StateDesignPattern
{
    internal class IAmBroken : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("You cant turn me off because I am broken..");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("You cant turn me off because I am broken..");
            return this;
        }
    }
}