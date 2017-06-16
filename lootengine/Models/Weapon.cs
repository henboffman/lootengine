using lootengine.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Weapon
    {
        public string Name;
        public int ItemLevel;        
        public int InventorySlots;
        public int RequiredHands;
        public int Durability;
        public int Damage;
        public int AttackSpeed;
        public DamageType DamageType;
        public Rarity Rarity;

        public Weapon () { }
    }
}
