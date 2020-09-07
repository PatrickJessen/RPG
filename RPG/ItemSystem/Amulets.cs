using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Randomize(iLevel);
        }

        public override void Randomize(int iLevel)
        {
            switch (ILevel)
            {
                case 1:
                    Vitality = rand.Next(1, 5);
                    Dexterity = rand.Next(1, 5);
                    Strength = rand.Next(1, 5);
                    Energy = rand.Next(1, 5);
                    Life = rand.Next(1, 5);
                    break;
                case 2:
                    Vitality = rand.Next(4, 9);
                    Dexterity = rand.Next(4, 9);
                    Strength = rand.Next(4, 9);
                    Energy = rand.Next(4, 9);
                    Life = rand.Next(4, 9);
                    break;
                case 3:
                    Vitality = rand.Next(9, 17);
                    Dexterity = rand.Next(9, 17);
                    Strength = rand.Next(9, 17);
                    Energy = rand.Next(9, 17);
                    Life = rand.Next(9, 7);
                    break;
                case 4:
                    Vitality = rand.Next(15, 25);
                    Dexterity = rand.Next(15, 25);
                    Strength = rand.Next(15, 25);
                    Energy = rand.Next(15, 25);
                    Life = rand.Next(15, 25);
                    break;
                case 5:
                    Vitality = rand.Next(25, 40);
                    Dexterity = rand.Next(25, 40);
                    Strength = rand.Next(25, 40);
                    Energy = rand.Next(25, 40);
                    Life = rand.Next(25, 40);
                    break;
                case 6:
                    Vitality = rand.Next(40, 70);
                    Dexterity = rand.Next(40, 70);
                    Strength = rand.Next(40, 70);
                    Energy = rand.Next(40, 70);
                    Life = rand.Next(40, 70);
                    break;
                default:
                    break;
            }
        }
    }
}
