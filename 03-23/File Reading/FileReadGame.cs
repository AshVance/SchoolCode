// Task 2 from "U11.3 - Worksheet" word doc.
// Accesses the "words.txt" file.
using System;
using System.IO;

namespace FileReadGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\My Documents\16+\Computer Science\C#FileReading2\FileReadGame\FileReadGame\words.txt";
            string[] file_text = File.ReadAllLines(path);

            int score = 0;

            foreach (string line in file_text)
            {
                Console.Write("\nGuess the word: ");
                string guess = Console.ReadLine();

                if (guess == line)
                {
                    score++;
                    Console.Write($"\nCongrats! You got it right! Your score is now {score}.\n");
                }
                else
                {
                    Console.Write($"\nBad luck, your score is still {score}.\n");
                }
            }

            Console.Write($"\nGame over. You scored {score} points. Well done!\n");
        }
    }
}
