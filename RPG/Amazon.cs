using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Amazon : Player
    {
        public Amazon() : base()
        {
            Strength = 20;
            Dexterity = 25;
            Vitality = 20;
            Energy = 15;
            Level = 1;
            Experience = 0;
            ExpToLevelUp = Level * 75;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Amazon";

            UpdateStats();
        }

        public override double DealDamage()
        {
            throw new NotImplementedException();
        }

        public override double HealPlayer()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            Strength += 1;
            Dexterity += 2;
            Vitality += 1;
            Energy += 1;
            Level += 1;
            Gold += 1000;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Dexterity * 1.5 + Strength;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Strength;
        }
    }
}
