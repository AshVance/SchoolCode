using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string LetterSeq(string letters)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string letter1 = Convert.ToString(letters[0]);
            string letter2 = Convert.ToString(letters[1]);
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter1)
                {
                    index1 = i;
                }
                else if (alphabet[i] == letter2)
                {
                    index2 = i+1;
                }
            }

            string[] sequence_array = new string[index2 - index1];
            int j = 0;
            for (int i = index1; i < index2; i++)
            {
                sequence_array[j] = alphabet[i];
                j++;
            }

            string sequence = string.Join("", sequence_array);

            return sequence;
        }

        static void Main(string[] args)
        {
            Console.Write("Please input two different letters in alphabetical order (no space): ");
            string letters = Console.ReadLine();
            Console.Write($"\nYour sequence: {LetterSeq(letters)}\n\n");
        }
    }
}
