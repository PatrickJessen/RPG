using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Necromancer : Player
    {
        public Necromancer() : base()
        {
            Strength = 15;
            Dexterity = 25;
            Vitality = 15;
            Energy = 25;
            Level = 1;
            Experience = 0;
            ExpToLevelUp = Level * 75;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Necromancer";

            UpdateStats();
        }

        public override double DealDamage()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            Strength += 1;
            Dexterity += 1;
            Vitality += 1;
            Energy += 2;
            Level += 1;
            Gold += 1000;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Vitality * 1.5 + Energy;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Strength;
        }
    }
}
