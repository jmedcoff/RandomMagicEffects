using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMagicEffects.Business_Logic
{
    class MagicList :IMagicList
    {

        private readonly List<string> magicEffects;

        public MagicList(List<string> ls)
        {
            magicEffects = ls;
        }
        // returns magic effect at index x as string
        public string getEffectAt(int x)
        {
            if (magicEffects[x].Length > 5)
            {
                return magicEffects[x].Substring(5);
            }
            else
            {
                return magicEffects[(x+1) % 10000].Substring(5);
            }
            
        }




    }
}
