using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class AngryCreator : EmojyCreatorcs
    { private string redMode;
      
        public AngryCreator(string redMode1)
        {
            redMode = redMode1;
        }

        public override Emojy CreatEmojy(int position)
        {
            return new Angry(position, redMode);
        }
    }
}
