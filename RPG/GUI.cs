using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.ItemSystem;
using System.Collections.ObjectModel;
using System.Media;

namespace RPG
{
    class GUI
    {
        Bosses[] bossArray = new Bosses[5];
        Bosses Andariel = new Bosses("Andariel", 5, 5);
        Bosses Duriel = new Bosses("Duriel", 5, 5);
        Bosses Mephisto = new Bosses("Mephisto", 5, 5);
        Bosses Diablo = new Bosses("Diablo", 5, 5);
        Bosses Baal = new Bosses("Baal", 5, 5);
        Player Druid = new Druid();
        Player Sorceress = new Sorceress();
        Player Paladin = new Paladin();
        Player Barbarian = new Barbarian();
        Player Assassin = new Assassin();
        Player Amazon = new Amazon();
        Player Necromancer = new Necromancer();
        List<Player> playerList = new List<Player>();

        public List<Items> playerInventory = new List<Items>();

        public List<Items> equippedGear = new List<Items>();

        string[] randomNames = new string[]
        {
            "Fallen",
            "Skeleton",
            "Zombie",
            "Rakanishu",
            "Fallen Shaman",
            "Corrupt Rogue",
            "Goatmen",
            "Vampire",
            "Claw Viper",
            "Megademon",
            "Oblivion Knight",
            "Abominable",
            "Blood Lord",
            "Corpsefire",
            "Bishibosh",
            "Coldcrow",
            "Blood Raven",
            "Bonebreaker",
            "Treehead Woodfist",
            "Griswold",
            "The Countess",
            "Pitspawn Fouldog",
            "Bone Ash",
            "The Smith",
            "The Cow King",
            "The Summoner",
            "Ismail Vilehand",
            "Toorc Icefist",
            "Izual",
            "Hephasto the Armorer",
            "Grand Vizier of Chaos",
            "Infector of Souls",
            "Lord De Seis",
            "Nihlathak",
            "Korlic",
            "Madawc",
            "Talic"
        };

        string[] helmNames = new string[]
        {
            "Shako",
            "Andariel's Visage",
            "Lore",
            "Valkyrie Wing",
            "Blackhorn's Face",
            "Vampire Gaze",
            "Crown of Ages"
        };

        string[] amuletNames = new string[]
        {
            "Mara's Kaleidoscope",
            "Metalgrid",
            "Highlord's Wraith",
            "The Rising Sun",
            "Crescent Moon",
            "Nokozan Relic",
            "The cat's Eye"
        };

        string[] chestNames = new string[]
        {
            "The Spirit Shroud",
            "Skin of the Vipermagi",
            "Duriel's Shell",
            "Shaftstop",
            "Tyrael's Might",
            "Arkaine's Valor",
            "Leviathan"
        };

        string[] ringNames = new string[]
        {
            "The Stone of Jordan",
            "Bul-Kathos' Wedding Band",
            "Raven Frost",
            "Manald Heal",
            "Nagelring",
            "Dwarf Star",
            "Whisp Projector"
        };

        string[] weaponNames = new string[]
        {
            "Lightsabre",
            "Azurewrath",
            "Frostwind",
            "Bloodmoon",
            "Djinn Slayer",
            "Headstriker",
            "Blade of Ali Baba"
        };

        string[] glovesNames = new string[]
        {
            "Bloodfist",
            "Chance Guards",
            "Magefist",
            "Frostburn",
            "Dracul's Grasp",
            "Soul Drainer",
            "Steelrend"
        };

        string[] bootsNames = new string[]
        {
            "Waterwalk",
            "War Traveler",
            "Gorerider",
            "Sandstorm Trek",
            "Marrowwalk",
            "Shadow Dancer",
            "Hotspur"
        };

        string[] shieldNames = new string[]
        {
            "Steelclash",
            "Moser's Blessed",
            "Lidless Wall",
            "Stormshield",
            "Lance Guard",
            "The Ward",
            "Stormguild"
        };

        string[] beltNames = new string[]
        {
            "String of Ears",
            "Arachnid Mesh",
            "Nosferatu's Coil",
            "Verdungo's Hearty Cord",
            "Razortail",
            "Goldwrap",
            "Snakecord"
        };

        ReadStory myStory = new ReadStory();

        Campaign camp = new Campaign();

        ExpSystem exp = new ExpSystem();

        ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

        char key = 'b';
        string userInput;

        bool turn = true;
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
            bossArray[0] = Andariel;
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
                    Console.Clear();
                    CharacterSelection();
                    break;
            }
        }

        private void MainMenuGraphic(Player player)
        {
            Console.Clear();
            Console.WriteLine(GUIFunctions.SquaregAlign());
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 1.{GUIFunctions.StringAlign("Fight Mobs")}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 2.{GUIFunctions.StringAlign("Fight Next Boss")}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 3.{GUIFunctions.StringAlign(player.Name + " Stats")}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 4.{GUIFunctions.StringAlign(player.Name + " Inventory")}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 5.{GUIFunctions.StringAlign("Item Shop")}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 6.{GUIFunctions.StringAlign("Heal " + player.Name)}#");
            Console.WriteLine($"#   {GUIFunctions.StringAlign("")}#");
            Console.WriteLine($"# 7.{GUIFunctions.StringAlign("Equipped Items")}#");
            Console.WriteLine(GUIFunctions.SquaregAlign());

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Press any key to start the fight!\0");
                    FightRandomMob(player);
                    BackToMenu(player);
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
                    camp.EquipGear(playerInventory, player.myItems);
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
                case "7":
                    DrawEquippedItems(player);
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
            Console.WriteLine($"{camp.PrintLootStat(playerInventory)}");
        }

        private void DrawEquippedItems(Player player)
        {
            Console.Clear();
                //Console.WriteLine($"{myList[i].Name} Ilevel: {myList[i].ILevel}");
                Console.WriteLine($"{camp.PrintLootStat2(player.myItems)}");
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
            Random rand = new Random();
            for (int i = 0; i < player.MyQuest.QuestStory; i++)
            {
                if (player.Life > 0)
                {
                    Console.WriteLine(myStory.ReadMyStory("Story" + player.MyQuest.QuestStory));
                    player.MyQuest.QuestStory += BossFight(player, bossArray[player.MyQuest.QuestStory++ -1]);

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
                    player.ExpToLevelUp = exp.ExpNeededForLevel(player);
                    player.Experience += player.Level * player.MyQuest.QuestStory * 5;
                    Console.WriteLine(player.Experience);
                    exp.LevelingUp(player);
                    Console.ReadLine();
                    return 1;
                }
            }
            return 0;
        }

        private void FightRandomMob(Player player)
        {
            Random rand = new Random();
            Bosses randomMob = new Bosses(randomNames[rand.Next(0, randomNames.Length)], player.MyQuest.QuestStory + 5 * 3, player.MyQuest.QuestStory + 3 * 3);
            double temp;
            while (player.Life > 0)
            {
                Console.ReadLine();
                temp = randomMob.Dmg;
                player.Life -= temp;
                Console.WriteLine($"{randomMob.Name} hit {player.Name} for {temp}");
                Console.WriteLine($"{player.Name} life is currently at: {player.Life}");
                Console.ReadLine();
                if (player.Life <= 0)
                {
                    Console.WriteLine($"{randomMob.Name} won the fight! better heal up and get some better gear!");
                    Console.ReadLine();
                    player.Life = 0;
                    BackToMenu(player);
                    break;
                }

                temp = player.Damage;
                randomMob.Life -= temp; //FIIIIIIIX
                DrawSkills(player);
                ChooseSkill(player);
                Console.WriteLine($"{player.Name} hit {randomMob.Name} for {temp}");
                Console.WriteLine($"{randomMob.Name} life is currently at: {randomMob.Life}");

                if (randomMob.Life <= 0)
                {
                    Console.WriteLine($"{player.Name} Won the fight!");
                    Items TempItem = camp.CallRandItem(player.myQuest.QuestStory);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You found " + TempItem.Name);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    playerInventory.Add(TempItem);
                    camp.PrintLootStat(playerInventory);
                    player.ExpToLevelUp = exp.ExpNeededForLevel(player);
                    player.Experience += player.Level * player.MyQuest.QuestStory * 3;
                    exp.LevelingUp(player);
                    Console.WriteLine($"{player.Name} gained {player.Experience} exp");
                    Console.ReadLine();
                    BackToMenu(player);
                    break;
                }
            }
        }

        private void DrawSkills(Player player)
        {
            Console.WriteLine($"Skill 1: {player.skillNr1}");
            Console.WriteLine($"Skill 2: {player.skillNr2}");
            Console.WriteLine($"Skill 3: {player.skillNr3}");
            Console.WriteLine($"Skill 4: {player.Potion}");
        }

        private void ChooseSkill(Player player)
        {
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    player.mySkills = Player.PlayerSkills.Skill1;
                    break;
                case "2":
                    player.mySkills = Player.PlayerSkills.Skill2;
                    break;
                case "3":
                    player.mySkills = Player.PlayerSkills.Skill3;
                    break;
                case "4":
                    player.healPlayer = Player.PlayerHeal.SmallPotion;
                    Console.WriteLine($"{player.Name} healed for {player.Heal}");
                    break;
            }
        }

        public void FightMob(Player player)
        {
            Random rand = new Random();
            Bosses randomMob = new Bosses(randomNames[rand.Next(0, randomNames.Length)], player.MyQuest.QuestStory + 5 * 3, player.MyQuest.QuestStory + 3 * 3);


        }
    }
}