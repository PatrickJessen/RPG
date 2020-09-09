using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Shields : Armor
    {
        public Shields(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            ItemType = "Shields";
        }
    }
}
