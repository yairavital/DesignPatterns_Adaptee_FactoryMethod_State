using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class VegetarianDiet: DietBase
    {
        private string menu="Banna";
        public int days;
        public string Name { get => "Vegetrain Diet"; private set { } }
        public VegetarianDiet(int days)
        {
            this.days = days;
        }
        public override string GetName()
        {
            return Name;
        }
        public override string GetMenu()
        {
            return menu;
        }

    }
}
