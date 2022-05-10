using AdapteTirgul;

//Implementaion the dollar Payment Class
Console.ForegroundColor = ConsoleColor.Green;
DollarPaycs doll = new DollarPaycs();
doll.Payment(100);
Console.ForegroundColor = ConsoleColor.Red;
doll.priceDollar = 12;
doll.Payment(20);
//Implementaion the Euro Payment Class
Console.ForegroundColor = ConsoleColor.White;
EuroPayment PaymentEuro = new EuroPayment();
PaymentEuro.Payment(100);
