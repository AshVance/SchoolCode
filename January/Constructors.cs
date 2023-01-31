using System;
using System.Threading;

namespace Constructors
{
    public class Enemy
    {
        private int health, damage, shield, turns;
        private string name, battleCry;

        public Enemy(int eHealth, int eDamage, int eShield, int eTurns, string eName, string eBattleCry)
        {
            health = eHealth;
            damage = eDamage;
            shield = eShield;
            turns = eTurns;
            name = eName;
            battleCry = eBattleCry;
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
        public int Shield
        {
            get
            {
                return shield;
            }
            set
            {
                shield = value;
            }
        }
        public int Turns
        {
            get
            {
                return turns;
            }
            set
            {
                turns = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string BattleCry
        {
            get
            {
                return battleCry;
            }
            set
            {
                battleCry = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy zombie = new Enemy(100, 20, 10, 7, "Walker", "Bleaaaurgh...");
            int myHealth = 70;
            int myShield = 40;
            int myDamage = 25;
            int myTurns = 8;
            string myVoice = "Aaaargh...";

            Console.WriteLine(zombie.Turns);

            while (zombie.Turns > 0 && myTurns > 0)
            {
                Console.WriteLine("A zombie approaches, what do you do?");
                string option = Console.ReadLine().ToLower();
                if (option == "attack")
                {
                    zombie.Health -= myDamage;
                    Console.WriteLine("The zombies health is now {0}", zombie.Health);
                    zombie.Turns -= 1;
                }
                else if (option == "dodge")
                {
                    Console.WriteLine("You successfully evaded the attack");
                    zombie.Turns -= 1;
                }
                else
                {
                    myHealth -= zombie.Damage;
                    Console.WriteLine("The zombie struck you");
                }

                if (myHealth < 0)
                {
                    char[] final = myVoice.ToCharArray();
                    foreach (char x in final)
                    {
                        Console.Write(x);
                        Thread.Sleep(50);
                    }
                    Console.WriteLine("\nYou are dead");
                    myTurns = 0;
                }
                else if (zombie.Health <= 0)
                {
                    char[] final = zombie.BattleCry.ToCharArray();
                    foreach (char x in final)
                    {
                        Console.Write(x);
                        Thread.Sleep(50);
                    }
                    Console.WriteLine("\nThe {0} is dead!", zombie.Name);
                    zombie.Turns = 0;
                }
            }
        }
    }
}