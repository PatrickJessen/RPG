using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ItemSystem
{
    class Items
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = id++; }
        }

        public string ItemType { get; set; }
        public string Name { get; set; }
        public int ILevel { get; set; }

        public Items(string name, int iLevel)
        {
            Id = 0;
            Name = name;
            ILevel = iLevel;
        }
    }
}
