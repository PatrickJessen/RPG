using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Barbarian : Player
    {
        public Barbarian()
        {
            Strength = 30;
            Dexterity = 20;
            Vitality = 25;
            Energy = 10;
            Level = 1;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Barbarian";

            UpdateStats();
        }

        public override void LevelUp()
        {
            Strength += 2;
            Dexterity += 1;
            Vitality += 1;
            Energy += 1;
            Level += 1;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Strength * 2;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Energy;
        }
    }
}
