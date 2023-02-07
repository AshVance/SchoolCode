// Work from "Programming paradigms.docx"
using System;

namespace AggregationTest
{
    public class AggAlien : AggEnemy
    {
        // Initialises empty variables for race/comms/shield
        private string a_race, a_comms;
        private int a_shield;
        private Attribute a_attribute;

        public AggAlien(string race, string comms, int shield, Attribute attribute)
        {
            a_race = race;
            a_comms = comms;
            a_shield = shield;
            a_attribute = attribute;
        }

        public string Race
        {
            get
            {
                return a_race;
            }
            set
            {
                a_race = value;
            }
        }
        public string Comms
        {
            get
            {
                return a_comms;
            }
            set
            {
                a_comms = value;
            }
        }
        public int Shield
        {
            get
            {
                return a_shield;
            }
            set
            {
                a_shield = value;
            }
        }
        public int Health
        {
            get
            {
                return a_attribute.Health;
            }
            set
            {
                a_attribute.Health = value;
            }
        }
        public int Damage
        {
            get
            {
                return a_attribute.Damage;
            }
            set
            {
                a_attribute.Damage = value;
            }
        }
    }

}

