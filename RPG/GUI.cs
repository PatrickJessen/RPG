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

        ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

        char key = 'b';
        string userInput;
        public void StartStory()
        {
            StartScreen();
            Console.ReadKey();
            Console.Clear();
            CharacterSelection();
            Console.ReadKey();
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
                    Story(Sorceress);
                    break;
                case "paladin":
                    Console.WriteLine("You have chosen the Paladin");
                    Story(Paladin);
                    break;
                case "barbarian":
                    Console.WriteLine("You have chosen the Barbarian");
                    Story(Barbarian);
                    break;
                case "amazon":
                    Console.WriteLine("You have chosen the Amazon");
                    Story(Amazon);
                    break;
                case "assassin":
                    Console.WriteLine("You have chosen the Assassin");
                    Story(Assassin);
                    break;
                case "necromancer":
                    Console.WriteLine("You have chosen the Necromancer");
                    Story(Necromancer);
                    break;
                case "druid":
                    Console.WriteLine("You have chosen the Druid");
                    Story(Druid);
                    break;
                default:
                    Console.WriteLine("Wrong input! Check your spelling.");
                    Console.ReadKey();
                    CharacterSelection();
                    break;
            }
        }

        private void MainMenuGraphic(Player player, Bosses boss)
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
            Console.WriteLine($"# 5. {player.Name} Shop                                       #");
            Console.WriteLine("################################################################");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Press any key to start the fight!");
                    if (boss.Life > 0)
                    {
                        BossFight(player, boss);
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(player.PrintStats());
                    Console.WriteLine("Press b to get back to menu!");
                    Console.ReadKey();
                    BackToMenu(player, boss);
                    break;
                case "4":
                    DrawInventory();
                    Console.ReadLine();
                    Console.WriteLine("Press b to get back to menu!");
                    BackToMenu(player, boss);
                    break;
                case "5":
                    DrawShop();
                    Console.ReadLine();
                    Console.WriteLine("Press b to get back to menu!");
                    BackToMenu(player, boss);
                    break;
                default:
                    Console.WriteLine("Wrong input! Check your spelling!");
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

        private void BackToMenu(Player player, Bosses boss)
        {
            if (Console.KeyAvailable)
            {
                keyPress = Console.ReadKey(true);
                key = keyPress.KeyChar;
            }
            if (key == 'b')
            {
                MainMenuGraphic(player, boss);
            }
        }

        private void Story(Player player)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(myStory.ReadMyStory("Story1"));
            MainMenuGraphic(player, Andarial);
            Console.WriteLine(myStory.ReadMyStory("Story2"));
            MainMenuGraphic(player, Duriel);
            Console.WriteLine(myStory.ReadMyStory("Story3"));
            MainMenuGraphic(player, Mephisto);
            Console.WriteLine(myStory.ReadMyStory("Story4"));
            MainMenuGraphic(player, Diablo);
            Console.WriteLine(myStory.ReadMyStory("Story5"));
            MainMenuGraphic(player, Baal);
            Console.WriteLine(myStory.ReadMyStory("Story6"));
        }

        private string BossFight(Player player, Bosses boss)
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
                    BackToMenu(player, boss);
                    break;
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
                    BackToMenu(player, boss);
                    break;
                }
            }
            return null;
        }
    }
}