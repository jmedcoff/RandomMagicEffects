using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMagicEffects.Business_Logic
{
    class MagicEffects :IMagicEffects
    {

        private Random rand = new Random();

        private IMagicList magicList;

        public MagicEffects(IMagicList ml)
        {
            magicList = ml;
        }

        public string getRandMagicEffect()
        {
            return magicList.getEffectAt(rand.Next() % 10000);
        }
    }
}
