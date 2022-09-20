using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_HUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;
            int health = 100;
            int score = 0;
            float multiplier = 1.0f;
            int level = 1;
            string[] levelMessages =
            {

            };
        }
        static void DisplayText()
        {
            Console.Clear();

            Console.WriteLine("======== Super Real Game That Exists !!! ========");
            Console.WriteLine("Level: " + level + "Lives: " + lives + "Health: " + health + "Score: " + score + "Multiplier: " + multiplier);
        }
    }
}
