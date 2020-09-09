﻿using RPG.ItemSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Player
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Energy { get; set; }
        public double Life { get; set; }
        public double Hitrate { get; set; }
        public double Damage { get; set; }
        public string Name { get; set;  }
        public int Level { get; set; }
        public double Experience { get; set; }
        public int ExpToLevelUp { get; set; }
        public int Gold { get; set; }
        public double Defense { get; set; }




        public Quest myQuest = new Quest();
        public Quest MyQuest
        {
            get { return myQuest; }
            set { myQuest = value; }
        }

        public ObservableCollection<Items> myItems = new ObservableCollection<Items>();

        public Player()
        {
            myItems.CollectionChanged += Items_CollectionChanged;
            myItems.Add(new Amulets("Amulets", 1, "Amulet"));
            myItems.Add(new ChestPlate("ChestPlate", 1, "Armor"));
            myItems.Add(new Belts("Belts", 1, "Belt"));
            myItems.Add(new Boots("Boots", 1, "Boots"));
            myItems.Add(new Gloves("Gloves", 1, "Gloves"));
            myItems.Add(new Helmet("Helmet", 1, "Helmet"));
            myItems.Add(new Rings("Rings", 1, "Ring"));
            myItems.Add(new Shields("Shields", 1, "Shields"));
            myItems.Add(new Weapons("Weapons", 1, "Weapon"));
        }

        public abstract void LevelUp();
            
        public abstract void UpdateStats();
            
        public string PrintStats()
        {
            return $"Name: {Name}\nLevel: {Level}\nLife: {Life}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}\nEnergy: {Energy}\nDamage: {Damage}\nExperience: {Experience}\nExp to next level: {ExpToLevelUp}\nGold: {Gold}";
        }



        public void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (Equipment item in e.NewItems)
                {
                    item.GiveStats(this);
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (Equipment item in e.OldItems)
                {
                    item.RemoveStats(this);
                }
            }
        }
    }
}
