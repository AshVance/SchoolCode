using System;

// Copied from board
namespace NewClasses
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            Circle CircleOne = new Circle(); // Creates an instance of the Circle class, there is no parameter for radius.
            // Circle class is found in "Circle.cs"

            Console.WriteLine("Please enter a radius: ");
            CircleOne.Radius = int.Parse(Console.ReadLine()); // Radius parameter is inputted here.

            Console.Write(CircleOne.Area());
            Console.WriteLine(" metres squared area");

            Console.Write(CircleOne.Circumference());
            Console.WriteLine(" metres circumference");

            Console.Write(CircleOne.Diameter());
            Console.WriteLine(" metres diameter");
        }
        #endregion
    }
}
