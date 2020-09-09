using RPG.ItemSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class ChestPlate : Armor
    {
        public ChestPlate(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            itemType = "Armor";
        }
    }
}
