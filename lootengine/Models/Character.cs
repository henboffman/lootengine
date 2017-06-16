using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Character
    {
        public string Name;
        public int Level;
        public int InventorySlots;
        public int UsedInventorySlots;
        public double Damage;
        public double AttackPerSecond;
        public int Health;
        public int Armor;

        public Character() { }
    }
}
