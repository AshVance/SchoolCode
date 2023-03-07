using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] seats_1 = new bool[5, 5];
            bool[,] seats_2 = new bool[5, 5];
            bool[,] seats_3 = new bool[5, 5];

            Random rnd = new Random();
            #region Array Population
            // Screen 1
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool booked = Convert.ToBoolean(rnd.Next(0, 2));
                    seats_1[i, j] = booked;
                }
            }
            // Screen 2
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool booked = Convert.ToBoolean(rnd.Next(0, 2));
                    seats_2[i, j] = booked;
                }
            }
            // Screen 3
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool booked = Convert.ToBoolean(rnd.Next(0, 2));
                    seats_3[i, j] = booked;
                }
            }
            #endregion

            Console.Write("Welcome to the cinema! Please select a film:\n1 - Quick & Angry\n" +
                "2 - Mister Peculiar\n3 - Cat in Shoes\n4 - Morbius\n5 - River's Two\nSelection: ");
            string movie_choice = Console.ReadLine();

            Console.Write("\nPlease input your screen number (1, 2 or 3): ");
            string screen_choice = Console.ReadLine();

            switch (screen_choice)
            {
                case "1":
                    //carry on from here
            }
        }
    }
}
