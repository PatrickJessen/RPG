using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class GUI
    {
        Bosses[] bossArray = new Bosses[5];
        Bosses Andarial = new Bosses("Andarial", 5, 5);
        Bosses Duriel = new Bosses("Duriel", 5, 5);
        Bosses Mephisto = new Bosses("Mephisto", 150, 120);
        Bosses Diablo = new Bosses("Diablo", 300, 400);
        Bosses Baal = new Bosses("Baal", 500, 700);
        Player Druid = new Druid();
        Player Sorceress = new Sorceress();
        Player Paladin = new Paladin();
        Player Barbarian = new Barbarian();
        Player Assassin = new Assassin();
        Player Amazon = new Amazon();
        Player Necromancer = new Necromancer();
        List<Player> playerList = new List<Player>();

        ReadStory myStory = new ReadStory();

        Campaign camp = new Campaign();

        ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

        char key = 'b';
        string userInput;
        public void StartStory()
        {
            AddBossesToList();
            StartScreen();
            Console.ReadKey();
            Console.Clear();
            CharacterSelection();
            Console.ReadKey();
        }

        private void AddBossesToList()
        {
            bossArray[0] = Andarial;
            bossArray[1] = Duriel;
            bossArray[2] = Mephisto;
            bossArray[3] = Diablo;
            bossArray[4] = Baal;
        }

        private void AddPlayersToList()
        {
            playerList.Add(Druid);
            playerList.Add(Sorceress);
            playerList.Add(Paladin);
            playerList.Add(Barbarian);
            playerList.Add(Assassin);
            playerList.Add(Amazon);
            playerList.Add(Necromancer);
        }

        private void StartScreen()
        {
            Console.WriteLine("Deckard Cain: Greetings hero. Choose your champion. -Enter to continue");
        }

        private void CharacterSelection()
        {
            AddPlayersToList();
            foreach (Player players in playerList)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(players.PrintStats() + "\n");
            }
            ChooseHero();
        }

        private void ChooseHero()
        {
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "sorceress":
                    Console.WriteLine("You have chosen the Sorceress");
                    MainMenuGraphic(Sorceress);
                    break;
                case "paladin":
                    Console.WriteLine("You have chosen the Paladin");
                    MainMenuGraphic(Paladin);
                    break;
                case "barbarian":
                    Console.WriteLine("You have chosen the Barbarian");
                    MainMenuGraphic(Barbarian);
                    break;
                case "amazon":
                    Console.WriteLine("You have chosen the Amazon");
                    MainMenuGraphic(Amazon);
                    break;
                case "assassin":
                    Console.WriteLine("You have chosen the Assassin");
                    MainMenuGraphic(Assassin);
                    break;
                case "necromancer":
                    Console.WriteLine("You have chosen the Necromancer");
                    MainMenuGraphic(Necromancer);
                    break;
                case "druid":
                    Console.WriteLine("You have chosen the Druid");
                    MainMenuGraphic(Druid);
                    break;
                default:
                    Console.WriteLine("Wrong input! Check your spelling.");
                    Console.ReadKey();
                    CharacterSelection();
                    break;
            }
        }

        private void MainMenuGraphic(Player player)
        {
            Console.Clear();
            Console.WriteLine("################################################################");
            Console.WriteLine("#                         MAIN MENU                            #");
            Console.WriteLine("# 1. Fight mobs                                                #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine("# 2. Fight next boss                                           #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine($"# 3. {player.Name} Stats                                       #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine($"# 4. {player.Name} Inventory                                   #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine("# 5. Item Shop                                                 #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine($"# 6. Heal {player.Name}                                       #");
            Console.WriteLine("################################################################");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Press any key to start the fight!");
                    Story(player);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(player.PrintStats());
                    Console.WriteLine("Press b to get back to menu!");
                    Console.ReadKey();
                    BackToMenu(player);
                    break;
                case "4":
                    DrawInventory();
                    Console.ReadLine();
                    Console.WriteLine("Press b to get back to menu!");
                    BackToMenu(player);
                    break;
                case "5":
                    DrawShop();
                    Console.ReadLine();
                    Console.WriteLine("Press b to get back to menu!");
                    BackToMenu(player);
                    break;
                case "6":
                    camp.HealPlayer(player);
                    Console.ReadLine();
                    Console.WriteLine("Press b to get back to menu!");
                    BackToMenu(player);
                    break;
                default:
                    Console.WriteLine("Wrong input! Check your spelling!");
                    BackToMenu(player);
                    break;
            }
        }


        private void DrawInventory()
        {
            Console.Clear();
            Console.WriteLine("################################################################");
            Console.WriteLine("#                         INVENTORY                            #");
            Console.WriteLine("#                          Headgear                            #");
            Console.WriteLine("#                                        Amulet                #");
            Console.WriteLine("#               Weapon                  Shield                 #");
            Console.WriteLine("#                         Chest Armor                          #");
            Console.WriteLine("#                      Ring        Ring                        #");
            Console.WriteLine("#                 Gloves     Belt                              #");
            Console.WriteLine("#                            Boots                             #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine("################################################################");
        }

        private void DrawShop()
        {
            Console.Clear();
            Console.WriteLine("################################################################");
            Console.WriteLine("#                            SHOP                              #");
            Console.WriteLine("#                          Headgear                            #");
            Console.WriteLine("#                                        Amulet                #");
            Console.WriteLine("#               Weapon                  Shield                 #");
            Console.WriteLine("#                         Chest Armor                          #");
            Console.WriteLine("#                      Ring        Ring                        #");
            Console.WriteLine("#                 Gloves     Belt                              #");
            Console.WriteLine("#                            Boots                             #");
            Console.WriteLine("#                                                              #");
            Console.WriteLine("################################################################");
        }

        private void BackToMenu(Player player)
        {
            if (Console.KeyAvailable)
            {
                keyPress = Console.ReadKey(true);
                key = keyPress.KeyChar;
            }
            if (key == 'b')
            {
                MainMenuGraphic(player);
            }
        }

        private void Story(Player player)
        {
            for (int i = 0; i < player.MyQuest.QuestStory; i++)
            {
                if (player.Life > 0)
                {
                    Console.WriteLine(myStory.ReadMyStory("Story" + player.MyQuest.QuestStory));
                    player.MyQuest.QuestStory += BossFight(player, bossArray[player.MyQuest.QuestStory +1]);
                    Console.ReadKey();
                    BackToMenu(player);
                }
            }
        }


        private int BossFight(Player player, Bosses boss)
        {
            double temp;
            while (player.Life > 0 || boss.Life > 0)
            {
                Console.ReadKey();
                temp = boss.Dmg;
                player.Life -= temp;
                Console.WriteLine($"{boss.Name} hit {player.Name} for {temp}");
                Console.WriteLine($"{player.Name} life is currently at: {player.Life}");
                Console.ReadKey();
                if (player.Life <= 0)
                {
                    Console.WriteLine($"{boss.Name} Won the fight! Game over! Better go get some more levels!");
                    Console.ReadLine();
                    player.Life = 0;
                    return 0;
                }

                temp = player.Damage;
                boss.Life -= temp;
                Console.WriteLine($"{player.Name} hit {boss.Name} for {temp}");
                Console.WriteLine($"{boss.Name} life is currently at: {boss.Life}");

                if (boss.Life <= 0)
                {
                    Console.WriteLine($"{player.Name} Won the fight!");
                    player.LevelUp();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Level Up!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(player.PrintStats());
                    Console.ReadLine();
                    return 1;
                }
            }
            return 0;
        }
    }
}