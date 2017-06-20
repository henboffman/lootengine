using lootengine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Item
    {
        public string Name{ get; set; }
        public int Level{ get; set; }
        public ItemType ItemType{ get; set; }
        public Rarity Rarity{ get; set; }
        public int Weight{ get; set; }
        public int ModifierCount{ get; set; }
        public List<int> Modifiers{ get; set; }

        public Item () {
            Name = "";
            Level = 1;
            Rarity = Rarity.Normal;
            Weight = 1;
            ModifierCount = 0;
            Modifiers = new List<int>();
        }
    }
}
