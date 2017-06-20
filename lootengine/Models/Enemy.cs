using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lootengine.Enums;

namespace lootengine.Models
{
    class Enemy
    {
        //    name
        //type[skeleton, etc.]

        //level: determined by environment level +/- 3

        //health: determined by level
        //damage: determined by level
        //damageType: [elemental, melee, ranged]
        //    rank:[normal, champion, elite, legendary]
        //    modifierCount: int
        //    modifiers:[] //number of modifiers determined by rank. Which modifiers determined randomly
        //    dropRate: float
        //    dropLevel: {0, (level + 10)}


        public string Name { get; set; }
        public int Type{ get; set; }
        public int Level{ get; set; }
        public int ExperienceYield{ get; set; }
        public int Health{ get; set; }
        public int Damage{ get; set; }
        public double AttackPerSecond{ get; set; }
        public DamageType DamageType{ get; set; }
        public EnemyType Rank{ get; set; }
        public int ModifierCount{ get; set; }
        public List<int> Modifiers{ get; set; }
        public double DropRate{ get; set; }
        public int DropLevel{ get; set; }

        public Enemy()
        {
            Name = "";
            Type = 0;
            Level = 0;
            ExperienceYield = 100;
            Health = 100;
            Damage = 5;
            AttackPerSecond = 0.5;
            DamageType = DamageType.Melee;
            Rank = EnemyType.Normal;
            ModifierCount = 0;
            Modifiers = new List<int>();
            DropRate = 1;
            DropLevel = 1;
    }

    public Enemy(Random random, int environmentLevel, EnemyType enemyType = EnemyType.Normal)
    {
        var plusOrMinusValue = random.Next(0, 2) * 2 - 1; //determines if plus or minus value

        if (plusOrMinusValue < 1) plusOrMinusValue = 1;

        Level = environmentLevel + (plusOrMinusValue * random.Next(0, 5));

        Health = 15 * Level;
        Damage = 1 * Level;

        Array damageTypes = Enum.GetValues(typeof(DamageType));
        DamageType = (DamageType)damageTypes.GetValue(random.Next(damageTypes.Length));

        //Array enemyTypes = Enum.GetValues(typeof(EnemyType));
        //Rank = (EnemyType)enemyTypes.GetValue(random.Next(enemyTypes.Length));
        Rank = enemyType;
    }

}
}
