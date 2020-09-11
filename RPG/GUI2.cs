using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class GUI2
    {
        string userInput;
        public void SelectSkills(Player player)
        {
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"Added +1 to {player.skillNr1}");
                    player.Skill1 += 1;
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine($"Added +1 to {player.skillNr2}");
                    player.Skill2 += 1;
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine($"Added +1 to {player.skillNr3}");
                    player.Skill3 += 1;
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}
