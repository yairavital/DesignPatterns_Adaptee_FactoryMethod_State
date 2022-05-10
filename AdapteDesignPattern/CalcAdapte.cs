using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteDesignPattern
{
    internal class CalcAdapte : IScientificCalc
    {
        private ISimpleCalc simpleCalc1 = new SimpleCalc();
        public double Add(double x, double y)
        {
            return (simpleCalc1.Add((int)x, (int)y));
        }

        public double Div(double x, double y)
        {
            return (simpleCalc1.Div((int)x, (int)y));
        }

        public double Mul(double x, double y)
        {
            return (simpleCalc1.Mul((int)x, (int)y));
        }

        public double Sub(double x, double y)
        {
            return (simpleCalc1.Sub((int)x, (int)y));
        }
    }
}
