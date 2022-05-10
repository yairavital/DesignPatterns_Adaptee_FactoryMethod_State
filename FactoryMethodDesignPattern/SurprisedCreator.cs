using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class SurprisedCreator : EmojyCreatorcs
    {
        private int surprisedLevel;
        public SurprisedCreator(int level)
        {
            surprisedLevel = level;
        }
        public override Emojy CreatEmojy(int position)
        {
            return new Surprised(position, surprisedLevel);
        }
    }
}
