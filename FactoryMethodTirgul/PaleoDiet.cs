using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class PaleoDiet: DietBase
    {
        public string level;
        private string menu = "Water";
        public string Name { get => "Paleo Diet"; private set { } }

        public PaleoDiet( string level)
        {
           this.level = level;
            
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
