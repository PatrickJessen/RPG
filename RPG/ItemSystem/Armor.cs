﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    abstract class Armor : Equipment
    {
        private double defense;

        public double Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        private int life;

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        protected Armor(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            Defense = defense;
            Life = life;
            Randomize(iLevel);
        }

        public override void Randomize(int iLevel)
        {
            Random rand = new Random();
            switch (ILevel)
            {
                case 1:
                    Defense = rand.Next(3, 9);
                    Life = rand.Next(3, 9);
                    break;
                case 2:
                    Defense = rand.Next(10, 17);
                    Life = rand.Next(10, 17);
                    break;
                case 3:
                    Defense = rand.Next(17, 25);
                    Life = rand.Next(17, 25);
                    break;
                case 4:
                    Defense = rand.Next(25, 35);
                    Life = rand.Next(25, 35);
                    break;
                case 5:
                    Defense = rand.Next(35, 50);
                    Life = rand.Next(35, 50);
                    break;
                case 6:
                    Defense = rand.Next(50, 70);
                    Life = rand.Next(50, 70);
                    break;
                default:
                    break;
            }
        }

        public override Player GiveStats(Player player)
        {
            player.Defense += Defense;
            player.Life += Life;

            return player;
        }

        public override Player RemoveStats(Player player)
        {
            player.Defense -= Defense;
            player.Life -= Life;

            return player;
        }
    }
}
