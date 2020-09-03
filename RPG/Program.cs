using RPG.ItemSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy boss = new Bosses("test", 150, 100);
            Console.WriteLine(boss.Dmg);
            GUI gui = new GUI();
            gui.StartStory();
        }
    }
}
