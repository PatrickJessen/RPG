using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Enemy
    {
        public string Name { get; set; }
        public double Dmg { get; set; }
        public double Life { get; set; }
        public Enemy()
        {
        }
    }
}
