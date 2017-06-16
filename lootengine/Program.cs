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
        static void Main(string[] args)
        {

            GenerateEnvironment();
            Console.ReadLine();
        }

        public static void GenerateEnvironment()
        {
            int environmentLevel = 5;
            var random = new Random();
            Console.WriteLine("{0,10}{1,10}{2,15}{3,15}", "Health", "Damage", "DamageType", "EnemyType");

            //create environment
            var environment = new Models.Environment(random);

            Console.WriteLine("pack count:" + environment.PackCount);

            //for pack size, generate pack

            for (int i = 0; i < environment.PackCount; i++)
            {
                GeneratePack(random, environment.Level);
            }
        }

        public static void GeneratePack(Random random, int environmentLevel)
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
        }
    }
}
