using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Rings : Equipment
    {
        public int Damage { get; set; }
        public int Vitality { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Energy { get; set; }
        public int Life { get; set; }

        public Rings(string name, int iLevel, string itemType) : base(name, iLevel, itemType)
        {
            iLevel = 1;
            ItemType = "Ring";
            Randomize(iLevel);
        }

        public override void Randomize(int iLevel)
        {
            Random rand = new Random();
            switch (ILevel)
            {
                case 1:
                    Damage = rand.Next(1, 5);
                    Vitality = rand.Next(1, 5);
                    Dexterity = rand.Next(1, 5);
                    Strength = rand.Next(1, 5);
                    Energy = rand.Next(1, 5);
                    Life = rand.Next(1, 5);
                    break;
                case 2:
                    Damage = rand.Next(4, 9);
                    Vitality = rand.Next(4, 9);
                    Dexterity = rand.Next(4, 9);
                    Strength = rand.Next(4, 9);
                    Energy = rand.Next(4, 9);
                    Life = rand.Next(4, 9);
                    break;
                case 3:
                    Damage = rand.Next(9, 17);
                    Vitality = rand.Next(9, 17);
                    Dexterity = rand.Next(9, 17);
                    Strength = rand.Next(9, 17);
                    Energy = rand.Next(9, 17);
                    Life = rand.Next(9, 7);
                    break;
                case 4:
                    Damage = rand.Next(15, 25);
                    Vitality = rand.Next(15, 25);
                    Dexterity = rand.Next(15, 25);
                    Strength = rand.Next(15, 25);
                    Energy = rand.Next(15, 25);
                    Life = rand.Next(15, 25);
                    break;
                case 5:
                    Damage = rand.Next(25, 40);
                    Vitality = rand.Next(25, 40);
                    Dexterity = rand.Next(25, 40);
                    Strength = rand.Next(25, 40);
                    Energy = rand.Next(25, 40);
                    Life = rand.Next(25, 40);
                    break;
                case 6:
                    Damage = rand.Next(40, 70);
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

        public override Player GiveStats(Player player)
        {
            player.Vitality += Vitality;
            player.Dexterity += Dexterity;
            player.Strength += Strength;
            player.Energy += Energy;
            player.Life += Life;

            return player;
        }

        public override Player RemoveStats(Player player)
        {
            player.Vitality -= Vitality;
            player.Dexterity -= Dexterity;
            player.Strength -= Strength;
            player.Energy -= Energy;
            player.Life -= Life;

            return player;
        }
    }
}
