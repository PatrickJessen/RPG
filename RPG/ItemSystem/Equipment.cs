﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    abstract class Equipment : Items
    {
        public Equipment(string name, int iLevel) : base(name, iLevel)
        {
        }

        public abstract void Randomize();
    }
}