using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTirgul
{
    internal abstract class DietBase
    {
        public string dietMenu;
        public abstract string GetName();
      public abstract string GetMenu();  
      
        
    }
}
