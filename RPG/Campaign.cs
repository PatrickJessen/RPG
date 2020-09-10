using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RPG.ItemSystem;

namespace RPG
{
    class Campaign
    {

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

        string userInput;

        public string HealPlayer(Player player)
        {
            double playerlife;
            playerlife = player.Life += player.Vitality * 5;
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

        Random rand = new Random();
        public Items CallRandItem(int itemlvl)
        {
            int temp = rand.Next(1, 100);
            if (Enumerable.Range(1, 100).Contains(temp))
            {
                return MakeRandItem(itemlvl);
            }
            return null;
        }

        private void MoveGear(List<Items> removeItem, ObservableCollection<Items> myList, int num)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].ItemType == removeItem[num].ItemType)
                {
                    myList.Add(removeItem[num]);
                    myList.RemoveAt(i);
                    removeItem.RemoveAt(num);
                    i = myList.Count + 1;
                }

            }
        }

        public void EquipGear(List<Items> removeItem, ObservableCollection<Items> myList)
        {
            userInput = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (userInput == i.ToString())
                {
                    MoveGear(removeItem, myList, i);
                }
            }
        }

        public string PrintLootStat(List<Items> item)
        {
            string combString ="";
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].GetType().Name.ToString() == "Amulets")
                {
                    combString  += $"{i}. {((Amulets)item[i]).Name}, Dex: {((Amulets)item[i]).Dexterity}, Vit: {((Amulets)item[i]).Vitality}, Str: {((Amulets)item[i]).Strength}, Nrg: {((Amulets)item[i]).Energy}, Life: {((Amulets)item[i]).Life}, Ilvl: {((Amulets)item[i]).ILevel}, Type: {((Amulets)item[i]).ItemType}# \n\n#";
                }
                else if (item[i].GetType().Name.ToString() == "Belts")
                {
                    combString += $"{i}. {((Belts)item[i]).Name}, Def: {((Belts)item[i]).Defense}, Life: {((Belts)item[i]).Life}, Ilvl: {((Belts)item[i]).ILevel}, Type: {((Belts)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "ChestPlate")
                {
                    combString += $"{i}. {((ChestPlate)item[i]).Name}, Def: {((ChestPlate)item[i]).Defense}, Life: {((ChestPlate)item[i]).Life}, Ilvl: {((ChestPlate)item[i]).ILevel}, Type: {((ChestPlate)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Rings")
                {
                    combString += $"{i}. {((Rings)item[i]).Name}, Dmg: {((Rings)item[i]).Damage}, Vit {((Rings)item[i]).Vitality}, Dex {((Rings)item[i]).Dexterity}, Life: {((Rings)item[i]).Life}, Ilvl: {((Rings)item[i]).ILevel}, Type: {((Rings)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Weapons")
                {
                    combString += $"{i}. {((Weapons)item[i]).Name}, Dmg: {((Weapons)item[i]).Damage}, Ilvl: {((Weapons)item[i]).ILevel}, Type: {((Weapons)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Shields")
                {
                    combString += $"{i}. {((Shields)item[i]).Name}, Def: {((Shields)item[i]).Defense}, Life: {((Shields)item[i]).Life}, Ilvl: {((Shields)item[i]).ILevel}, Type: {((Shields)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Gloves")
                {
                    combString += $"{i}. {((Gloves)item[i]).Name}, Def: {((Gloves)item[i]).Defense}, Life: {((Gloves)item[i]).Life}, Ilvl: {((Gloves)item[i]).ILevel}, Type: {((Gloves)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Boots")
                {
                    combString += $"{i}. {((Boots)item[i]).Name}, Def: {((Boots)item[i]).Defense}, Life: {((Boots)item[i]).Life}, Ilvl: {((Boots)item[i]).ILevel}, Type: {((Boots)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Belts")
                {
                    combString += $"{i}. {((Helmet)item[i]).Name}, Def: {((Helmet)item[i]).Defense} Life: {((Helmet)item[i]).Life}, Ilvl: {((Helmet)item[i]).ILevel}, Type: {((Helmet)item[i]).ItemType}# \n\n";
                }
            }
            return combString;
        }

        public string PrintLootStat2(ObservableCollection<Items> item)
        {
            string combString = "";
            for (int i = 0; i < item.Count; i++)
            {
                if (item[i].GetType().Name.ToString() == "Amulets")
                {
                    combString += $"{i}. {((Amulets)item[i]).Name}, Dex: {((Amulets)item[i]).Dexterity}, Vit: {((Amulets)item[i]).Vitality}, Str: {((Amulets)item[i]).Strength}, Nrg: {((Amulets)item[i]).Energy}, Life: {((Amulets)item[i]).Life}, Ilvl: {((Amulets)item[i]).ILevel}, Type: {((Amulets)item[i]).ItemType}# \n\n#";
                }
                else if (item[i].GetType().Name.ToString() == "Belts")
                {
                    combString += $"{i}. {((Belts)item[i]).Name}, Def: {((Belts)item[i]).Defense}, Life: {((Belts)item[i]).Life}, Ilvl: {((Belts)item[i]).ILevel}, Type: {((Belts)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "ChestPlate")
                {
                    combString += $"{i}. {((ChestPlate)item[i]).Name}, Def: {((ChestPlate)item[i]).Defense}, Life: {((ChestPlate)item[i]).Life}, Ilvl: {((ChestPlate)item[i]).ILevel}, Type: {((ChestPlate)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Rings")
                {
                    combString += $"{i}. {((Rings)item[i]).Name}, Dmg: {((Rings)item[i]).Damage}, Vit {((Rings)item[i]).Vitality}, Dex {((Rings)item[i]).Dexterity}, Life: {((Rings)item[i]).Life}, Ilvl: {((Rings)item[i]).ILevel}, Type: {((Rings)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Weapons")
                {
                    combString += $"{i}. {((Weapons)item[i]).Name}, Dmg: {((Weapons)item[i]).Damage}, Ilvl: {((Weapons)item[i]).ILevel}, Type: {((Weapons)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Shields")
                {
                    combString += $"{i}. {((Shields)item[i]).Name}, Def: {((Shields)item[i]).Defense}, Life: {((Shields)item[i]).Life}, Ilvl: {((Shields)item[i]).ILevel}, Type: {((Shields)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Gloves")
                {
                    combString += $"{i}. {((Gloves)item[i]).Name}, Def: {((Gloves)item[i]).Defense}, Life: {((Gloves)item[i]).Life}, Ilvl: {((Gloves)item[i]).ILevel}, Type: {((Gloves)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Boots")
                {
                    combString += $"{i}. {((Boots)item[i]).Name}, Def: {((Boots)item[i]).Defense}, Life: {((Boots)item[i]).Life}, Ilvl: {((Boots)item[i]).ILevel}, Type: {((Boots)item[i]).ItemType}# \n\n";
                }
                else if (item[i].GetType().Name.ToString() == "Belts")
                {
                    combString += $"{i}. {((Helmet)item[i]).Name}, Def: {((Helmet)item[i]).Defense} Life: {((Helmet)item[i]).Life}, Ilvl: {((Helmet)item[i]).ILevel}, Type: {((Helmet)item[i]).ItemType}# \n\n";
                }
            }
            return combString;
        }

        Random r = new Random(Guid.NewGuid().GetHashCode());
        private Items MakeRandItem(int itemlvl)
        {
            switch (r.Next(1, 9))
            {
                case 1:
                    return new Amulets(amuletNames[r.Next(0, amuletNames.Length)], itemlvl, "Amulet");
                case 2:                    
                    return new Belts(beltNames[r.Next(0, beltNames.Length)], itemlvl, "Belt");
                case 3:
                    return new ChestPlate(chestNames[r.Next(0, chestNames.Length)], itemlvl, "Armor");
                case 4:
                    return new Rings(ringNames[r.Next(0, ringNames.Length)], itemlvl, "Ring");
                case 5:
                    return new Weapons(weaponNames[r.Next(0, weaponNames.Length)], itemlvl, "Weapon");
                case 6:
                    return new Shields(shieldNames[r.Next(0, shieldNames.Length)], itemlvl, "Shields");
                case 7:
                    return new Gloves(glovesNames[r.Next(0, glovesNames.Length)], itemlvl, "Gloves");
                case 8:
                    return new Boots(bootsNames[r.Next(0, bootsNames.Length)], itemlvl, "Boots");
                case 9:
                    return new Helmet(helmNames[r.Next(0, helmNames.Length)], itemlvl, "Helmet");
            }
            return null;
        }
    }
}

