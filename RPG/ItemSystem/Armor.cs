using System;
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


        public Armor(string name, int iLevel, double defense, int life) : base(name, iLevel)
        {
            Defense = defense;
            Life = life;
        }

        public override void Randomize()
        {
            throw new NotImplementedException();
        }
    }
}
