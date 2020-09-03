using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Player
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Energy { get; set; }
        public double Life { get; set; }
        public double Hitrate { get; set; }
        public double Damage { get; set; }
        public string Name { get; set;  }
        public int Level { get; set; }
        public int Gold { get; set; }

        public abstract void LevelUp();

        public abstract void UpdateStats();
            
        public string PrintStats()
        {
            return $"Name: {Name}\nLevel: {Level}\nLife: {Life}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}\nEnergy: {Energy}\nDamage: {Damage}\n {Gold}";
        }
    }
}
