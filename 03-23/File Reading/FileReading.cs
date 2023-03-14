// Modified code from the "U11.3 - Read" powerpoint.
using System;
using System.IO;

namespace FileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change path if necessary.
            string path = @"H:\My Documents\16+\Computer Science\C#FileReading\FileReading\FileReading\inventory.csv";
            string[] file_text = File.ReadAllLines(path);

            Console.Write("Please input the item you would like to find: ");
            string user_search = Console.ReadLine();
            bool item_found = false;

            foreach (string line in file_text)
            {
                string[] items = line.Split(',');
                foreach (string item in items)
                {
                    if (item == user_search)
                    {
                        item_found = true;
                    }
                }
            }

            if (item_found == true)
            {
                Console.Write($"\nFound your {user_search}!");
            }
            else
            {
                Console.Write($"\nSorry, could not find your {user_search}.");
            }
        }
    }
}
