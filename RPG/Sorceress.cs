﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Sorceress : Player
    {
        public Sorceress()
        {
            Strength = 10;
            Dexterity = 25;
            Vitality = 10;
            Energy = 35;
            Level = 1;
            Experience = 0;
            ExpToLevelUp = Level * 75;
            Gold = 0;
            MyQuest.QuestStory = 1;

            Name = "Sorceress";

            UpdateStats();
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
            Damage = Energy * 2;
            Life = Vitality * 1.5;
            Hitrate = Dexterity * 1.5 + Energy;
        }
    }
}
