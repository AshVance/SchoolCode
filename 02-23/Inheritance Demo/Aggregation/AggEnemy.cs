// Work from "Programming paradigms.docx"
using System;

namespace AggregationTest
{
    public class AggEnemy
    {
        // Initialises three empty boolean variables
        private bool hold_weapon;
        private bool headshot_only;
        private bool is_alive;

        // Handles the get/set procedures for each parameter
        public bool HoldWeapon
        {
            get
            {
                return hold_weapon;
            }
            set
            {
                hold_weapon = value;
            }
        }
        public bool HeadshotOnly
        {
            get
            {
                return headshot_only;
            }
            set
            {
                headshot_only = value;
            }
        }
        public bool IsAlive
        {
            get
            {
                return is_alive;
            }
            set
            {
                is_alive = value;
            }
        }

    }
}
