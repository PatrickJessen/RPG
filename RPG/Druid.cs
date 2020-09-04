using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Druid : Player
    {
        public Druid()
        {
            Strength = 15;
            Dexterity = 20;
            Vitality = 25;
            Energy = 20;
            Level = 1;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Druid";

            UpdateStats();
        }
        public override void LevelUp()
        {
            Strength += 1;
            Dexterity += 1;
            Vitality += 2;
            Energy += 1;
            Level += 1;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Dexterity * 1.5 + Energy;
            Life = Vitality * 5;
            Hitrate = Dexterity * 1.5 + Strength;
        }
    }
}
