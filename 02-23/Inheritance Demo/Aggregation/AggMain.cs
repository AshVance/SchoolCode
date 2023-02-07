// Work from "Programming paradigms.docx"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationTest
{
    class AggMain
    {
        static void Main(string[] args)
        {
            bool menu = true;

            Attribute z = new Attribute(100, 100, 20);
            Attribute a = new Attribute(100, 100, 23);
            AggZombie walker = new AggZombie("Walker", "eeuuurrghaah...", 0, z);
            AggAlien martian = new AggAlien("Martian", "Merp", 32, a);

            walker.HoldWeapon = false;
            walker.HeadshotOnly = true;
            walker.IsAlive = true;

            Console.WriteLine("The Z Chronicles - ZED AGAIN");
            while (menu == true)
            {
                Console.WriteLine("**--- 1 : New Game ---**");
                Console.WriteLine("**--- 2 : Quit Game ---**");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    AggGame game = new AggGame();
                    menu = false;
                    game.Run(walker, martian);
                }
            }
            Console.ReadKey();
        }
    }
}
