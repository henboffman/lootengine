using lootengine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lootengine
{
    class Program
    {
        public static Character MainCharacter = new Character();

        static void Main(string[] args)
        {   
            var running = true;

            while (running)
            {
                Level();
            }
            
            Console.ReadLine();
        }

        static void Level()
        {
            var CurrentEnvironment = GenerateEnvironment();
            while (CurrentEnvironment.Packs.Count > 0) {
                EngagePack(CurrentEnvironment);
            }
            Console.WriteLine("All packs defeated! Next Level...");

            Console.ReadLine();
        }

        public static void EngagePack(Models.Environment CurrentEnvironment)
        {
            //find pack
            //foreach is a crude solution to this
            var packIndex = 0;
            while(CurrentEnvironment.Packs.Count > 0)
            {
                AttackPack(CurrentEnvironment.Packs[packIndex]);
                if (CurrentEnvironment.Packs[packIndex].Count == 0)
                {
                    CurrentEnvironment.Packs.RemoveAt(packIndex);
                    packIndex++;
                }
                
            }

            
            
        }

        public static void AttackPack(List<Enemy> pack)
        {
            var index = 0;
            while (pack.Count > 0)
            {
                Console.WriteLine("remaining in pack:" + pack.Count);
                EngageEnemy(MainCharacter, pack[index]);
                if (pack[index].Health == 0)
                {
                    Console.WriteLine("Enemy defeated!");
                    pack.RemoveAt(index);
                    index++;
                }

            }

            Console.WriteLine("Pack defeated!");
                
                
            
        }

        public static void EngageEnemy(Character hero, Enemy enemy)
        {
            while (hero.Health > 0 && enemy.Health > 0)
            {
                HeroAttack(hero, enemy);
            }
        }

        public static void HeroAttack(Character hero, Enemy enemy) {
            //establish timer
            DateTime attackStart = new DateTime();
            attackStart = DateTime.Now;
            
            var attacksPerSecond = 1 / hero.AttackPerSecond;
            var nextAttack = attackStart.AddSeconds(attacksPerSecond);
            
                if (nextAttack <= DateTime.Now)
            {
                attackStart = DateTime.Now;
                nextAttack = attackStart.AddSeconds(attacksPerSecond);
            }

            if (nextAttack <= DateTime.Now)
            {
                enemy.Health -= hero.Damage;
                Console.WriteLine("enemy health:" + enemy.Health);
                attackStart = DateTime.Now;
                nextAttack = attackStart.AddSeconds(attacksPerSecond);
            }
            


            
            //timer check
            //attack
            //update health
        }

        public static Models.Environment GenerateEnvironment()
        {
            int environmentLevel = 2;
            var random = new Random();
            Console.WriteLine("{0,10}{1,10}{2,15}{3,15}", "Health", "Damage", "DamageType", "EnemyType");

            //create environment
            var environment = new Models.Environment(random);

            Console.WriteLine("pack count:" + environment.PackCount);

            //for pack size, generate pack

            for (int i = 0; i < environment.PackCount; i++)
            {
                environment.Packs.Add(GeneratePack(random, environment.Level));
            }
            return environment;
        }

        public static List<Enemy> GeneratePack(Random random, int environmentLevel)
        {
            var pack = new List<Enemy>();
            var packSize = random.Next(1, 10);
            Console.WriteLine("packSize: " + packSize);
            for (int j = 0; j < packSize; j++)
            {
                var enemy = new Enemy(random, environmentLevel);
                pack.Add(enemy);
                Console.WriteLine("{0,10}{1,10}{2,15}{3,15}", enemy.Health, enemy.Damage, enemy.DamageType, enemy.Rank);
            }
            return pack;
        }
    }
}
