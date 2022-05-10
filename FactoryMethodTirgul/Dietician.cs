using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethodTirgul;
namespace FactoryMethodTirgul
{
    internal class Dietician
    {
        private DietBase diet;
        public DietBase GetDiett(double weight, double height)
        {
            double ibm = IBMCalulator(weight, height);
            if (ibm > 20 && ibm < 40)
                diet = new CreatAtkinsDiet(3).GetDiet();
            if (ibm < 20)
                diet = new CreatPaleoDiet("Hard").GetDiet();
            else
                diet = new CreatVegetarianDiet(23).GetDiet();
            return diet;

        }
     
        public double IBMCalulator(double weight, double height)
        {
            double d = (weight / height);
            return Math.Pow(d, 2);

        }
    }
}
