using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Paladin : Player
    {
        public Paladin()
        {
            Strength = 25;
            Dexterity = 20;
            Vitality = 15;
            Energy = 15;
            Level = 1;

            Name = "Paladin";

            UpdateStats();
        }

        public override void LevelUp()
        {
            Strength += 1;
            Dexterity += 2;
            Vitality += 1;
            Energy += 1;
            Level += 1;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Dexterity * 1.5 + Strength;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Energy;
        }
    }
}
