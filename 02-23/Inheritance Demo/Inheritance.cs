// Work from "Programming paradigms.docx"
using System;

namespace Inheritance
{
    #region Vehicle Class
    class Vehicle // Base class (parent)
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    #endregion

    #region Car Class
    class Car : Vehicle // Derived class (child)
    {
        public string model_name = "Mustang";
    }
    #endregion

    #region Main
    class Program
    {
        static void Main(string[] args)
        {
            // Create a car object
            Car new_car = new Car();

            // Call the honk() method (from the Vehicle class) on the new_car object

        }
    }
    #endregion
}
