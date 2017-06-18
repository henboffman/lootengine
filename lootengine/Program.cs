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
        }

        public static void EngagePack(Models.Environment CurrentEnvironment)
        {
            //find pack
            //foreach is a crude solution to this
            var index = 0;
            while(CurrentEnvironment.Packs.Count > 0)
            {
                AttackPack(CurrentEnvironment.Packs[index]);
                index++;
            }

            
            
        }

        public static void AttackPack(List<Enemy> pack)
        {
            foreach (var enemy in pack)
            {
                Console.WriteLine("remaining in pack:" + pack.Count);
                EngageEnemy(MainCharacter, enemy);
            }
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
