﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Helmet : Armor
    {
        public Helmet(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            ItemType = "Helmet";
        }
    }
}
