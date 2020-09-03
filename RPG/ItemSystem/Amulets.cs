using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Amulets : Equipment
    {
        public int Vitality { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Energy { get; set; }
        public int Life { get; set; }

        Random rand = new Random(Guid.NewGuid().GetHashCode());
        public Amulets(string name, int iLevel) : base(name, iLevel)
        {
            iLevel = 1;
            Randomize();
        }

        public override void Randomize()
        {
            if (ILevel == 1)
            {
                Vitality = rand.Next(1, 5);
                Dexterity = rand.Next(1, 5);
                Strength = rand.Next(1, 5);
                Energy = rand.Next(1, 5);
                Life = rand.Next(1, 5);
            }
        }
    }
}
