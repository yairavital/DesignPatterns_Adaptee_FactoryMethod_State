using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal class CreatAtkinsDiet : FactoryDiet
    {
        private DietBase diet;
        private int days;
    public CreatAtkinsDiet(int days)
        {
            this.days = days;
        }
  


        public override DietBase GetDiet()
        {
          return new AtkinsDiet(days);
        }
    }
}
