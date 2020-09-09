using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    abstract class Equipment : Items
    {
        protected Equipment(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
        }

        public abstract void Randomize(int iLevel);

        public abstract Player GiveStats(Player player);

        public abstract Player RemoveStats(Player player);
    }
}
