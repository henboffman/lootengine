using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine.Models
{
    class Environment
    {
        //name: string
        //level: int
        //modifierCount: int //chance of modifier on environment roll
        //modifiers:[]
        //numberOfPacks:int   //roll number of packs on environment instantiation

        public string Name{ get; set; }
        public int Level{ get; set; }
        public int ModifierCount{ get; set; }
        public List<int> Modifiers{ get; set; }
        public int PackCount{ get; set; }
        public List<List<Enemy>> Packs{ get; set; }

        public Environment(Random random = null, int level = 5, int packCount = 5)
        {
            Name = "Dungeon";
            Level = level;
            ModifierCount = 0;
            Modifiers = new List<int>();
            Packs = new List<List<Enemy>>();
            if (random == null)
            {
                PackCount = packCount;
            } else
            {
                PackCount = random.Next(1, 5);
            }
        }
        
    }
}

