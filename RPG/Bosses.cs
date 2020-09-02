using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bosses
    {
        public string Name { get; set; }
        private int dmg;

        public int Dmg
        {
            get { return rand.Next(5 + dmg, 40 + dmg); }
            set { dmg = value; }
        }

        public double Life { get; set; }
        Random rand = new Random();
        public Bosses(string name, int dmg, int life)
        {
            Name = name;
            Dmg = dmg;
            Life = life;
        }
    }
}
