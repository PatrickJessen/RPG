using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        Random rand = new Random();
        public string CallRandItem(int itemlvl)
        {
            int temp = rand.Next(1, 100);
            if (Enumerable.Range(1, 50).Contains(temp))
            {
                return MakeRandItem(itemlvl);
            }
            return null;
        }

        Random r = new Random(Guid.NewGuid().GetHashCode());
        private string MakeRandItem(int itemlvl)
        {
            switch (r.Next(1,9))
            {
                case 1:
                    new Amulets(amuletNames[r.Next(0, amuletNames.Length)], itemlvl);
                    return $"You found {amuletNames[r.Next(0, amuletNames.Length)]}";
                case 2:
                    new Belts(beltNames[r.Next(0, beltNames.Length)], itemlvl);
                    return $"You found {beltNames[r.Next(0, beltNames.Length)]}";
                case 3:
                    new ChestPlate(chestNames[r.Next(0, chestNames.Length)], itemlvl);
                    return $"You found {chestNames[r.Next(0, chestNames.Length)]}";
                case 4:
                    new Rings(ringNames[r.Next(0, ringNames.Length)], itemlvl);
                    return $"You found {ringNames[r.Next(0, ringNames.Length)]}";
                case 5:
                    new Weapons(weaponNames[r.Next(0, weaponNames.Length)], itemlvl);
                    return $"You found {weaponNames[r.Next(0, weaponNames.Length)]}";
                case 6:
                    new Shields(shieldNames[r.Next(0, shieldNames.Length)], itemlvl);
                    return $"You found {shieldNames[r.Next(0, shieldNames.Length)]}";
                case 7:
                    new Gloves(glovesNames[r.Next(0, glovesNames.Length)], itemlvl);
                    return $"You found {glovesNames[r.Next(0, glovesNames.Length)]}";
                case 8:
                    new Boots(bootsNames[r.Next(0, bootsNames.Length)], itemlvl);
                    return $"You found {bootsNames[r.Next(0, bootsNames.Length)]}";
                case 9:
                    new Helmet(helmNames[r.Next(0, helmNames.Length)], itemlvl);
                    return $"You found {helmNames[r.Next(0, helmNames.Length)]}";
            }
            return null;
        }
    }
}

