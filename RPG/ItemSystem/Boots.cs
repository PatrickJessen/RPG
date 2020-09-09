using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Boots : Armor
    {
        public Boots(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            ItemType = "Boots";
        }
    }
}
