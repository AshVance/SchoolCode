using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Enemy.cs Class Parameters:
Holds weapon (bool) - hold_weapon
Headshot only (bool) - headshot_only
Is alive (bool) - headshot_only
Health (integer) - health
*/

namespace TextGame
{
    class TextGameMain
    {
        #region Main
        static void Main(string[] args)
        {
            EnemyEncounter();
        }
        #endregion

        #region Encounter Master Program
        static void EnemyEncounter()
        {
            Enemy alien = new Enemy();
            alien.HoldWeapon = false;
            alien.HeadshotOnly = false;
            alien.IsAlive = true;
            alien.Health = 100;

            Console.Write("An alien appears, he looks angry. You spot the laser gun gripped tightly by his hand.\n");

            while (alien.IsAlive == true)
            {
                /* Player options:
                Attack - deal damage to the enemy but take reduced damage in return
                Dodge - high chance of avoiding damage and smaller chance of counter-attacking
                Run - low chance of running away and avoiding damage */
                Console.Write("\nYou can attack (a), attempt to dodge (d) or attempt to run (r): ");
                string choice = Console.ReadLine().ToLower();
                
                switch (choice)
                {
                    case "a": // Attack
                        Random rnd = new Random();
                        int damage = rnd.Next(4, 8) * 10; // Possible damages (40, 50, 60, 70, 80)
                        Console.Write($"\n{FlavTextGeneration(choice)}");
                        break;
                    case "d": // Dodge
                        // dodge logic
                        break;
                    case "r": // Run
                        // run logic
                        break;
                    default:
                        Console.Write("Invalid choice! Please try again...\n");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        #endregion

        #region Flavour Text Generation
        static string FlavTextGeneration(string behaviour)
        {
            if (behaviour == "a") // Attack
            {
                Random rnd = new Random();
                int text_index = rnd.Next(0, 3);
                string text = FlavourTexts.flavour_texts_attack[text_index];
                return text;
            }
            else if (behaviour == "d") // Dodge
            {
                Random rnd = new Random();
                int text_index = rnd.Next(0, 3);
                string text = FlavourTexts.flavour_texts_dodge[text_index];
                return text;
            }
            else // Run
            {
                Random rnd = new Random();
                int text_index = rnd.Next(0, 3);
                string text = FlavourTexts.flavour_texts_run[text_index];
                return text;
            }
        }
        #endregion
    }
}
