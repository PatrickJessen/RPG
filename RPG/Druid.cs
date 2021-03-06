﻿using RPG.ItemSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Druid : Player
    {
        public Druid() : base()
        {
            Strength = 15;
            Dexterity = 20;
            Vitality = 25;
            Energy = 20;
            Level = 1;
            Experience = 0;
            //ExpToLevelUp = 75 * Level;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Druid";

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
            Dexterity += 1;
            Vitality += 2;
            Energy += 1;
            Level += 1;
            Gold += 1000;
            UpdateStats();
        }

        public override void UpdateStats()
        {
            Damage = Dexterity * 1.5 + Energy;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Strength;
        }
    }
}
