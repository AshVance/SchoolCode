using System;
using System.Threading;

/* Enemy.cs Class Parameters:
Holds weapon (bool) - hold_weapon
Headshot only (bool) - headshot_only
Is alive (bool) - headshot_only
Health (integer) - health
*/

namespace TextGame // Change to namespace TextGame when uploading to GitHub.
{
    class TextGameMain
    {
        #region Main
        static void Main(string[] args)
        {
            Console.Write("Welcome to a text-based adventure game.\n");
            while (true)
            {
                Console.Write("\n1 - Simulate Combat\n9 - Quit\nPlease make a selection: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        int player_hp = 100;
                        EnemyEncounter(player_hp);
                        break;
                    case "9":
                        Console.Write("\n\nThank you for trying my game....\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nInvalid input. Please try again...\n");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        #endregion

        #region Encounter Master Program
        static void EnemyEncounter(int player_hp)
        {
            // Change this so parameters are dynamic
            Enemy alien = new Enemy();
            alien.HoldWeapon = true;
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
                        alien.Health -= damage;
                        Console.Write($"\n{FlavTextGeneration(choice)}\nIts remaining HP is {alien.Health}.\n");
                        break;
                    case "d": // Dodge
                        // dodge logic
                        break;
                    case "r": // Run
                        // run logic
                        break;
                    default:
                        Console.Write("\nInvalid choice! Please try again...\n");
                        Thread.Sleep(1000);
                        break;
                }

                if (player_hp <= 0)
                {
                    Console.Write("\nYou've died! Better luck next time...\n");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

                if (alien.Health <= 0)
                {
                    Console.Write($"\nNice! The alien is dead! Your remaining HP is {player_hp}.");
                    alien.IsAlive = false;
                    Thread.Sleep(3000);
                    Console.Clear();
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
