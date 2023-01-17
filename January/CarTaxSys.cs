using System;

// This work is from the L1 OOP Basics powerpoint.
namespace CarTaxSystem
{
    class CarTaxSys
    {
        #region Main
        static void Main(string[] args)
        {
            Car CarOne = new Car(); // Creates a new instance of the Car class.
            // Class properties:
            // car_model (string)
            // car_make (string)
            // fuel_type (string)
            // emissions (integer)

            // The user inputs the various attributes of their car.
            Console.Write("Please input the car's model: ");
            CarOne.car_model = Console.ReadLine();
            Console.Write("Please input the car's manufacturer: ");
            CarOne.car_make = Console.ReadLine();
            Console.Write("Please input whether it is diesel, petrol or electric: ");
            CarOne.fuel_type = Console.ReadLine();
            Console.Write("Please input the car's emission levels (0 - 100): ");
            CarOne.emissions = int.Parse(Console.ReadLine());

            int tax_owed = CarOne.CalculateTax(); // This runs the CalculateTax function in the Car class, which returns the tax owed.

            Console.Write($"\nFor your {CarOne.car_make} {CarOne.car_model} (fuel type: {CarOne.fuel_type}), you owe £{tax_owed}.\n");
        }
        #endregion
    }
}
