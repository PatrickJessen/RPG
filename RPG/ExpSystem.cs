using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class ExpSystem
    {
        private void ExpGrowth(Player player)
        {
            if (player.Level < 100)
            {
                player.LevelUp();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Level Up!");
                Console.ForegroundColor = ConsoleColor.Blue;
                player.Experience = 0;
                Console.WriteLine(player.PrintStats());
            }
        }

        public int ExpNeededForLevel(Player player)
        {
            return 75 * (1 + (player.Level - 1) * player.Level / 2);
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
