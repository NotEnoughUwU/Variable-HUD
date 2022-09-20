using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_HUD
{
    internal class Program
    {
        static int lives;
        static int health;
        static int score;
        static float multiplier;
        static int level;
        static string name;
        static int killcount;

        static void Main(string[] args)
        {
            Console.WriteLine("Please input a name");
            name = Console.ReadLine();

            lives = 3;
            health = 100;
            score = 0;
            multiplier = 1.0f;
            level = 1;
            killcount = 0;

            DisplayHud();
            Console.ReadKey(true);
        }
        static void DisplayHud()
        {
            Console.Clear();

            Console.WriteLine("==================== Super Real Game That Exists !!! ====================");
            Console.WriteLine(" | " + name + " | Level: " + level + " | Lives: " + lives + " | Health: " + health + " | Score: " + score + " | Killcount: " + killcount + " | Multiplier: " + multiplier + " |");
        }

        static void HitByEnemy()
        {
            Console.WriteLine(name + " was hit by an enemy!");
            int damageTaken = 25;
            Console.WriteLine(name + " took " + damageTaken + " damage!");
            health -= damageTaken;

            if (health <= 0)
            {
                lives--;

                if (lives == 0)
                {
                    health = 0;
                }
                else
                {
                    health = 100;
                }
            }
        }
        static void ExtraLife()
        {
            Console.WriteLine(name + " picked up an extra life!");
            lives++;
        }
        static void KillEnemy()
        {
            int enemyPoints = 100;
            float pointsGainedFloat = enemyPoints * multiplier;
            int pointsGainedInt = (int)pointsGainedFloat;

            Console.WriteLine(name + " killed an enemy and gained " + pointsGainedInt + " points!");
            score += pointsGainedInt;
            killcount++;
        }
        static void IncreaseMultiplier()
        {
            float multiplierIncrease = 0.1f;

            Console.WriteLine(name + " picked up an item, increasing their multiplier by " + multiplierIncrease + "!");
            multiplier += multiplierIncrease;
        }
    }
}
