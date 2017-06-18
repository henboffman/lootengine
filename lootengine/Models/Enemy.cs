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

        
        public string Name;
        public int Type;
        public int Level;
        public int Health;
        public int Damage;
        public double AttackPerSecond;
        public DamageType DamageType;
        public EnemyType Rank;
        public int ModifierCount;
        public List<int> Modifiers;
        public double DropRate;
        public int DropLevel;

        public Enemy (Random random, int environmentLevel, EnemyType enemyType = EnemyType.Normal) {
            var plusOrMinusValue = random.Next(0, 2) * 2 - 1; //determines if plus or minus value

            if (plusOrMinusValue < 1) plusOrMinusValue = 1;

            Level = environmentLevel + (plusOrMinusValue * random.Next(0, 5));

            Health = 15 * Level;
            Damage = 1 * Level;

            Array damageTypes = Enum.GetValues(typeof(DamageType));            
            DamageType= (DamageType)damageTypes.GetValue(random.Next(damageTypes.Length));

            //Array enemyTypes = Enum.GetValues(typeof(EnemyType));
            //Rank = (EnemyType)enemyTypes.GetValue(random.Next(enemyTypes.Length));
            Rank = enemyType;
        }

    }
}
