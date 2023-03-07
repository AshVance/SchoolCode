// Copied from "U11.2 - Worksheet.docx"
using System;

namespace _2DArrays
{
    class Program
    {
        public class multidimensional
        {
            public static void Main()
            {
                int i, j;
                int[,] arr1 = new int[8, 8];

                Console.Write("\n\n Read a 2D array of size 3x3 and print the matrix :\n");
                Console.Write("------------------------------------------------------\n");


                /* Loop A - Stored values into the array */
                Console.Write("Input elements in the matrix :\n");
                for (i = 1; i < 4; i++)
                {
                    for (j = 1; j < 4; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                /* Loop B - Stored values into the array */

                Console.Write("\n The matrix is : \n");
                for (i = 1; i < 4; i++)
                {
                    Console.Write("\n");
                    for (j = 1; j < 4; j++)
                        Console.Write(string.Format("{0,3} ", arr1[i, j]));
                }
                Console.Write("\n\n");
            }
        }

    }
}
