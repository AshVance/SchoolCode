// Work from "Programming paradigms.docx"
using System;
using System.Threading;

namespace AggregationTest
{
    public class AggGame
    {
        private string input;
        private bool alive = true;

        private void ZombieAttack(AggZombie g_zombie, AggAlien g_alien, bool block)
        {
            if (block == true)
            {
                Console.WriteLine("You blocked the attack!");
            }
            else if (g_alien.Shield > g_zombie.Damage)
            {
                g_alien.Shield -= g_zombie.Damage;
                Console.WriteLine("Shield damaged! Health: {0} | Shield: {1}", g_alien.Health, g_alien.Shield);
            }
            else if (g_alien.Shield < g_zombie.Damage && g_alien.Shield > 0)
            {
                g_alien.Shield = 0;
                Console.WriteLine("Shield broken! Health: {0} | Shield: {1}", g_alien.Health, g_alien.Shield);
            }
            else if (g_alien.Shield <= 0 && g_alien.Health > 0)
            {
                g_alien.Health -= g_zombie.Damage;
                if (g_alien.Health < 0)
                {
                    Console.WriteLine("You are dead");
                    alive = false;
                }
                else
                {
                    Console.WriteLine("Health damaged! Health: {0} | Shield: {1}\n", g_alien.Health, g_alien.Shield);
                }
            }
            else
            {
                Console.WriteLine("You are dead");
                alive = false;
            }

        }
        private void AlienAttack(AggZombie g_zombie, AggAlien g_alien)
        {
            if (g_zombie.Health > 0)
            {
                g_zombie.Health -= g_alien.Damage;
                if (g_zombie.Health > 0)
                {
                    Console.WriteLine("{0} Damaged! Health: {1}\n", g_zombie.Type, g_zombie.Health);
                }
                else
                {

                    char[] final = g_zombie.Voice.ToCharArray();
                    foreach (char x in final)
                    {
                        Console.Write(x);
                        Thread.Sleep(50);
                    }
                    Console.WriteLine("\nThe {0} is dead!", g_zombie.Type);
                    alive = false;
                }
            }
            else
            {
                Console.WriteLine("The {0} is dead!", g_zombie.Type);
                alive = false;
            }
        }

        public void Run(AggZombie g_zombie, AggAlien g_alien)
        {
            Console.WriteLine("You approach a {0}, it goes to attack you. \n\n", g_zombie.Type);

            while (alive == true)
            {
                Console.WriteLine("\nYou are dangerously close to the {0}, what do you do?", g_zombie.Type);
                input = Console.ReadLine();
                if (input.ToUpper() == "ATTACK")
                {
                    Console.WriteLine("The {0} hits you first", g_zombie.Type);
                    ZombieAttack(g_zombie, g_alien, false);
                    if (alive == true)
                    {
                        AlienAttack(g_zombie, g_alien);
                    }
                }
                else if (input.ToUpper() == "BLOCK")
                {
                    ZombieAttack(g_zombie, g_alien, true);
                }
                else
                {
                    Console.WriteLine("Nope, that didn't work. Zombie got a free hit\n\n");
                    ZombieAttack(g_zombie, g_alien, false);
                }
            }
        }
    }
}
