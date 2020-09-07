﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Weapons : Equipment
    {
        public double Damage { get; set; }

        public Weapons(string name, int iLevel) : base(name, iLevel)
        {
            Randomize(iLevel);
        }

        public override void Randomize(int iLevel)
        {
            Random rand = new Random();
            switch (ILevel)
            {
                case 1:
                    Damage = rand.Next(3, 9);
                    break;
                case 2:
                    Damage = rand.Next(10, 17);
                    break;
                case 3:
                    Damage = rand.Next(17, 25);
                    break;
                case 4:
                    Damage = rand.Next(25, 35);
                    break;
                case 5:
                    Damage = rand.Next(35, 50);
                    break;
                case 6:
                    Damage = rand.Next(50, 70);
                    break;
                default:
                    break;
            }
        }
    }
}
