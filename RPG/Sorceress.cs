using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Sorceress : Player
    {
        public int FasterCastRate { get; set; }
        public int Fireskills { get; set; }
        public int Lightningskills { get; set; }
        public int ColdSkills { get; set; }

        private double fireball;

        public double Fireball
        {
            get { return fireball = FasterCastRate * Level + Fireskills + Energy; }
            set { fireball = value; }
        }

        private double lightning;

        public double Lightning
        {
            get { return lightning = FasterCastRate * Level + Lightningskills + Energy; }
            set { lightning = value; }
        }

        private double frostbolt;

        public double Frostbolt
        {
            get { return frostbolt = FasterCastRate * Level + ColdSkills + Energy; }
            set { frostbolt = value; }
        }

        private double drinkPotion;

        public double DrinkPotion
        {
            get { return Life += Vitality / 2; }
            set { drinkPotion = value; }
        }


        //PlayerSkills mySkills = new PlayerSkills();

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
            Fireskills = 1;
            Lightningskills = 1;
            ColdSkills = 1;

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
                    return Fireball;
                case PlayerSkills.Skill2:
                    return Lightning;
                case PlayerSkills.Skill3:
                    return Frostbolt;
            }
            return 0;
        }

        public override double HealPlayer()
        {
            if (healPlayer == PlayerHeal.SmallPotion)
            {
                return DrinkPotion;
            }
            return 0;
        }
    }
}
