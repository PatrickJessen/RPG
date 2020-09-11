using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Sorceress : Player
    {

        private double drinkPotion;

        public double DrinkPotion
        {
            get { return Life += Vitality / 2; }
            set { drinkPotion = value; }
        }

        public Sorceress() : base()
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
            FasterCastRate = 3;
            Skill1 = FasterCastRate * Level + Skill1 + Energy + Damage;
            Skill2 = FasterCastRate * Level + Skill2 + Energy;
            Skill3 = FasterCastRate * Level + Skill3 + Energy;

            skillNr1 = "Fireball";
            skillNr2 = "Lightning";
            skillNr3 = "Frostbolt";
            Potion = "Potion";

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
            Damage += DealDamage();
            Life += Vitality * 1.5;
            Hitrate += Dexterity * 1.5 + Energy;
            Heal += HealPlayer();
        }

        public override double DealDamage()
        {
            switch (mySkills)
            {
                case PlayerSkills.Skill1:
                    return Skill1;
                case PlayerSkills.Skill2:
                    return Skill2;
                case PlayerSkills.Skill3:
                    return Skill3;
            }
            return 0;
        }

        public override double HealPlayer()
        {
            if (mySkills == PlayerSkills.Potion)
            {
                return DrinkPotion;
            }
            return 0;
        }
    }
}
