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

        public string Name;
        public int Level;
        public int ModifierCount;
        public List<int> Modifiers;
        public int PackCount;
        public List<List<Enemy>> Packs;

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

