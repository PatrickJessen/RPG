using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Bosses : Enemy
    {
        Random rand = new Random();

        public Bosses(string name, int dmg, int life, int speed)
        {
            Name = name;
            Dmg = RandomDamage(dmg);
            Life = life;
            Speed = speed;
        }


        private int RandomDamage(int dmg)
        {
            dmg = rand.Next(5 + dmg, 40 + dmg);
            return dmg;
        }
    }
}
