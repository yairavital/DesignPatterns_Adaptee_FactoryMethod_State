using StateDesignPattern;
Console.ForegroundColor = ConsoleColor.Blue;
Context context = new Context(new IAMOn());
context.TurnOffRequest();
context.TurnOnRequest();
context.TurnOnRequest();