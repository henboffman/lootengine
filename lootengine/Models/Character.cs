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
        public int ExperienceForNextLevel { get; set; }
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
            ExperienceForNextLevel = 400;
            CarryWeight = 20;
            InventoryWeight = 5;
            Damage = 10;
            AttackPerSecond = 1;
            Health = 250;
            Armor = 10;
        }

        /// <summary>
        /// Determines if the hero has enough experience for next level
        /// </summary>
        private void CheckExperience()
        {   
            if (Experience >= ExperienceForNextLevel)
            {
                NextLevel();
                GetExperienceForNextLevel();
            }
        }

        /// <summary>
        /// Increments the character level
        /// </summary>
        private void NextLevel()
        {
            Console.WriteLine("Level Increased!");            
            Level++;
        }

        /// <summary>
        /// Retrieves experience required for next level
        /// </summary>
        private void GetExperienceForNextLevel()
        {
            //get and set experience required for next level
            //this is done on level up to reduce the number of database requests to once per level
            //ExperienceForNextLevel = Experience.Where(x => x.Level == Level + 1).Experience;
            //todo: add this once database configured and EF added
        }
    }
}
