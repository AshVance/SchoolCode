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
            Console.Write("Welcome to a text-based adventure game.");
            while (true)
            {
                Console.Write("\n1 - Simulate Combat\n9 - Quit\nPlease make a selection: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
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
            Random rnd = new Random();
            // Change this so parameters are dynamic.
            Enemy alien = new Enemy();
            alien.HoldWeapon = true;
            alien.HeadshotOnly = false;
            alien.IsAlive = true;
            alien.Health = 100;

            Console.Write($"\nAn alien appears, he looks quite angry. {FlavourTexts.splash_text[rnd.Next(0, 4)]} You spot the laser gun gripped tightly by his hand.\n");

            while (alien.IsAlive == true)
            {
                /* Player options:
                Attack - deal damage to the enemy but take reduced damage in return
                Dodge - high chance of avoiding damage and smaller chance of counter-attacking, instantly killing the enemy.
                Run - low chance of running away and avoiding damage */
                Console.Write($"Player HP: {player_hp}\nAlien HP: {alien.Health}\nYou can attack (a), attempt to dodge (d) or attempt to run (r): ");

                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "a": // Attack
                        // add counter attack 
                        int damage = rnd.Next(4, 9) * 10; // Possible damages (40, 50, 60, 70, 80)
                        alien.Health -= damage;
                        // Success parameter is unused but required by program to function.
                        Console.Write($"\n{FlavTextGeneration(choice, false)}\nIts remaining HP is {alien.Health}.\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "d": // Dodge
                        int dodge_roll = rnd.Next(1, 11); // Rolls for a dodge.
                        if (dodge_roll <= 5) // 50% success chance
                        {
                            Console.Write($"\nYou dodged! {FlavTextGeneration(choice, true)}\nYou try to counter...\n");
                            int counter_roll = rnd.Next(1, 11); // Rolls for a counter-attack.
                            if (counter_roll <= 2) // 20% success chance
                            {
                                alien.Health -= alien.Health;
                                Console.Write($"\n{FlavTextGeneration("c", true)} You wipe the floor with the alien, draining its remaining health.\nPress any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Write($"\n{FlavTextGeneration("c", false)} You both stare at each other in surprise, not a scratch on either of you!\nPress any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else // If failed, alien lands successful attack.
                        {
                            int damage_taken = rnd.Next(1, 4) * 10; // Possible damages (10, 20, 30)
                            player_hp -= damage_taken;
                            Console.Write($"\nYour dodge failed! {FlavTextGeneration(choice, false)} You take {damage_taken} damage.\nYour remaining HP is {player_hp}.\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "r": // Run
                        // run logic
                        break;
                    default:
                        Console.Write("\nInvalid choice! Please try again...\n");
                        Thread.Sleep(3000);
                        Console.Clear();
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
                    Console.Write($"\nNice! The alien is dead! Your remaining HP is {player_hp}.\nPress any key to continue...");
                    alien.IsAlive = false;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        #endregion

        #region Flavour Text Generation
        static string FlavTextGeneration(string action, bool success)
        {
            Random rnd = new Random();
            if (action == "a") // Attack
            {
                string text = FlavourTexts.ft_attack[rnd.Next(0, 4)];
                return text;
            }
            else if (action == "d") // Dodge
            {
                if (success == true) // Successful dodge
                {
                    string text = FlavourTexts.ft_dodge_success[rnd.Next(0, 4)];
                    return text;
                }
                else // Failed dodge
                {
                    string text = FlavourTexts.ft_dodge_fail[rnd.Next(0, 4)];
                    return text;
                } 
            }
            else if (action == "c") // Counter
            {
                if (success == true) // Successful counter
                {
                    string text = FlavourTexts.ft_counter_success[rnd.Next(0, 2)];
                    return text;
                }
                else // Failed counter
                {
                    string text = FlavourTexts.ft_counter_fail[rnd.Next(0, 2)];
                    return text;
                }
            }
            else // Run
            {
                string text = FlavourTexts.ft_run[rnd.Next(0, 4)];
                return text;
            }
        }
        #endregion
    }
}
