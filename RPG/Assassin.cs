using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Assassin : Player
    {
        public Assassin() : base()
        {
            Strength = 20;
            Dexterity = 20;
            Vitality = 20;
            Energy = 25;
            Level = 1;
            Experience = 0;
            ExpToLevelUp = Level * 75;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Assassin";

            UpdateStats();
        }

        public override void LevelUp()
        {
            Strength += (Level % 2 == 1 ? 2 : 1);
            Dexterity += (Level % 2 == 0 ? 2 : 1);
            Vitality += 1;
            Energy += 1;
            Level += 1;
            Gold += 1000;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Dexterity * (1.5 + Energy);
            Life = Vitality * 1.5;
            Hitrate = Dexterity * (1.5 + Strength);
        }
    }
}
