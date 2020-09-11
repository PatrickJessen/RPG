using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class ExpSystem
    {
        GUI2 gui = new GUI2();
        private void ExpGrowth(Player player)
        {
            if (player.Level < 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Level Up!");
                Console.ForegroundColor = ConsoleColor.Blue;
                player.Experience = 0;
                Console.WriteLine(player.PrintStats());
                player.LevelUp();
                Console.WriteLine($"1. {player.skillNr1}");
                Console.WriteLine($"2. {player.skillNr2}");
                Console.WriteLine($"3. {player.skillNr3}");
                gui.SelectSkills(player);
            }
        }

        public int ExpNeededForLevel(Player player)
        {
            return 1 * (1 + (player.Level - 1) * player.Level / 2);
        }

        public void LevelingUp(Player player)
        {
            if (player.Experience >= player.ExpToLevelUp)
            {
                ExpGrowth(player);
            }
        }
    }
}
