using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Weapons : Equipment
    {
        private double damage;

        public double Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Weapons(string name, int iLevel, double damage) : base(name, iLevel)
        {
            Damage = damage;
        }

        public override void Randomize()
        {
            throw new NotImplementedException();
        }
    }
}
