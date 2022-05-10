using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class CoolCreator : EmojyCreatorcs
    {
        private string colorGlasses;
    public CoolCreator(string color)
        {
            this.colorGlasses = color;
        }
        public override Emojy CreatEmojy(int position)
        {
            return new Cool(position, colorGlasses);
        }
    }
}
