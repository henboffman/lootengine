using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int CarryWeight { get; set; }
        public int InventoryWeight { get; set; }
        public int Damage { get; set; }
        public double AttackPerSecond { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Character()
        {
            Name = "new";
            Level = 1;
            Experience = 0;
            CarryWeight = 20;
            InventoryWeight = 5;
            Damage = 10;
            AttackPerSecond = 1;
            Health = 250;
            Armor = 10;


        }
    }
}
