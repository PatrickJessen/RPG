using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Campaign
    {
        public string HealPlayer(Player player)
        {
            double playerlife;
            playerlife = player.Life = player.Vitality * 5;
            if (player.Life <= 0 && player.Life != playerlife)
            {
                player.Life = player.Vitality * 1.5;
                return $"{player.Name} Has been fully healed";
            }
            else
            {
                return $"{player.Name} is already at full health";
            }
        }
    }
}
