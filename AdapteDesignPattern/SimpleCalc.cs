using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapteDesignPattern
{
    internal class SimpleCalc : ISimpleCalc
    {
        int ISimpleCalc.Add(int x, int y)
        {
            return x + y;
        }

        int ISimpleCalc.Div(int x, int y)
        {
            return x - y;
                }

        int ISimpleCalc.Mul(int x, int y)
        {
            return x * y;
        }

        int ISimpleCalc.Sub(int x, int y)
        {
            return x / y;
        }
    }
}
