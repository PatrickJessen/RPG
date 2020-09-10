using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class FightMethods
    {
        string userInput;
        private bool turn;
        public void CheckWhoGoesFirst(Player player, Bosses boss)
        {
            if (boss.Speed > player.FasterCastRate)
            {
                turn = false;
            }
            else
            {
                turn = true;
            }
        }

        public string FirstStrike(Player player, Bosses boss)
        {
            if (turn == true)
            {
                DrawSkills(player);
                turn = false;
                return ChooseSkill(player, boss);
            }
            else if (turn == false)
            {
                player.Life -= boss.Dmg;
                turn = true;
                return $"{boss.Name} hit {player.Name} for {boss.Dmg}";
            }
            return null;
        }

        public void DrawSkills(Player player)
        {
            Console.WriteLine($"Skill 1: {player.skillNr1}");
            Console.WriteLine($"Skill 2: {player.skillNr2}");
            Console.WriteLine($"Skill 3: {player.skillNr3}");
            Console.WriteLine($"Skill 4: {player.Potion}");
        }

        public string ChooseSkill(Player player, Bosses boss)
        {
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    player.mySkills = Player.PlayerSkills.Skill1;
                    boss.Life -= player.Damage;
                    return $"{player.Name} hit {boss.Name} for {player.Damage}";
                case "2":
                    player.mySkills = Player.PlayerSkills.Skill2;
                    boss.Life -= player.Damage;
                    return $"{player.Name} hit {boss.Name} for {player.Damage}";
                case "3":
                    player.mySkills = Player.PlayerSkills.Skill3;
                    boss.Life -= player.Damage;
                    return $"{player.Name} hit {boss.Name} for {player.Damage}";
                case "4":
                    player.mySkills = Player.PlayerSkills.Potion;
                    player.Life += player.Heal;
                    return $"{player.Name} healed for {player.Life += player.Heal}";
            }
            return null;
        }

        //public string CheckWhoDied(Player player, Bosses boss)
        //{
        //    if (player.Life <= 0)
        //    {
        //        return $"{player.Name} died, better go heal up and come back stronger!";
        //    }
        //    else if (boss.Life <= 0)
        //    {
        //        return $"{boss.Name} was slain by {player.Name}";
        //    }
        //    return null;
        //}
    }
}
