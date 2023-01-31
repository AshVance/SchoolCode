using System;

namespace NewClasses
{
    internal class Circle // Creates a new Circle class.
    {
        public int Radius; // Creates an empty public integer variable for the circle's radius.

        public double Area() // Creates a function that returns the area of the circle.
        {
            return Math.PI * Math.Pow(Radius, 2); // Area of a circle formula: pi*r^2
        }

        public double Circumference() // Creates a function that returns the circumference of the circle.
        {
            return 2 * Math.PI * Radius; // Circumference of a circle formula: 2pi*r
        }

        public double Diameter() // Creates a function that returns the diameter of the circle. 
        {
            return Radius * 2; // Diameter of a circle formula: 2r
        }
    }
}
