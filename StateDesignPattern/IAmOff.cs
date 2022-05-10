namespace StateDesignPattern
{
    internal class IAmOff : ILightState
    {
        public ILightState TurnOff()
        {
            Console.WriteLine("Opps now I am broken..");
            return new IAmBroken();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Now I am on");
            return new IAMOn();
        }
    }
}