using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class AtkinsDiet: DietBase
    {
        public int days;

        private string menu = "Eggs";
     
        public string Name { get=>"Atkins Diet"; private set { } }
        public AtkinsDiet(int days) 
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
