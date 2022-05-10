using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class CreatPaleoDiet : FactoryDiet
    {
        private string level;
     public CreatPaleoDiet(string level)
        {
            this.level = level;
        }

        public override DietBase GetDiet()
        {
            return new PaleoDiet(level);
        }
    }
}
