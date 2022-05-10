using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class CreatVegetarianDiet : FactoryDiet
    {
        private int days;
    public CreatVegetarianDiet(int days)
        {
            this.days = days;
        }
        public override DietBase GetDiet()
        {
            return new VegetarianDiet(days);
        }
    }
}
