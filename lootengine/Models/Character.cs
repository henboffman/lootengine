using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Character
    {
        public string Name = "new";
        public int Level = 1;
        public int CarryWeight = 20;
        public int InventoryWeight = 5;
        public double Damage = 10;
        public double AttackPerSecond = 1;
        public int Health = 200;
        public int Armor = 10;

        public Character()
        {
            
        }
    }
}
