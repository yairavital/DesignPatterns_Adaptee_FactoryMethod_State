using AdapteDesignPattern;

IScientificCalc scientificCalc = new ScientifCalc();
ISimpleCalc simpleCalc = new SimpleCalc();

CalcAdapte calcAdap = new CalcAdapte();
int xInt = 3;
int yInt = 4;

    PrintMathResults(calcAdap, xInt, yInt);
double x = 3.3;
double y = 4.3;

PrintMathResults(calcAdap, x, y);


static void PrintMathResults(IScientificCalc calculator, double x, double y)
{
    Console.WriteLine(calculator.Add(x, y));

    Console.WriteLine(calculator.Sub(x, y));

    Console.WriteLine(calculator.Div(x, y));

    Console.WriteLine(calculator.Mul(x, y));
}