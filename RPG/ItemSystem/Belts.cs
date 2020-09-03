using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Belts : Armor
    {

        public Belts(string name, int iLevel, double defense, int life) : base(name, iLevel, defense, life)
        {

        }
        public override void Randomize()
        {
            throw new NotImplementedException();
        }
    }
}
