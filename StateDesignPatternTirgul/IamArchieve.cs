namespace StateDesignPatternTirgul
{
    internal class IamArchieve : IMessageState
    {
        public IMessageState MoveToArchieve()
        {
            Console.WriteLine("I already in the archieve");
            return this;
        }

        public IMessageState SendMessage()
        {
            Console.WriteLine("You cant sent message from the archieve");
            return this;
        }
        public IMessageState RemoveFromArchieve()
        {
            Console.WriteLine("The message remvoe from archieve and passed to rough- befor send");
            return new BeforSend();
        }
    }
}