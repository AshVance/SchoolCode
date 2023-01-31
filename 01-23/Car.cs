// Accessed by CarTaxSys.cs
namespace CarTaxSystem
{
    internal class Car
    {
        // Declares empty variables of each property.
        internal string car_model;
        internal string car_make;
        internal string fuel_type;
        internal int emissions;

        internal int CalculateTax() // Function that returns the tax owed.
        {
            if (emissions == 0) // If the car is electric, no tax.
                return 0;
            else if (emissions > 50) // Above 50 emissions, tax is £200.
                return 200;
            else // Otherwise, tax is £120.
                return 120;
        }
    }
}
