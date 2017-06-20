using lootengine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models.Items
{
    class Weapon:Item
    {
        public int Damage{ get; set; }
        public DamageType DamageType{ get; set; }
        public int Hands{ get; set; }
        public int Durability{ get; set; }

        public Weapon() {
            Damage = 10;
            DamageType = DamageType.Melee;
            Hands = 1;
            Durability = 100;
        }
    }
}
