// Work from "Programming paradigms.docx"
using System;

namespace AggregationTest
{
    public class AggZombie : AggEnemy
    {
        private string z_type, z_voice;
        private int z_respawns;
        private Attribute z_attribute;

        public AggZombie(string type, string voice, int respawns, Attribute attribute)
        {
            z_type = type;
            z_voice = voice;
            z_respawns = respawns;
            z_attribute = attribute;
        }

        public string Type
        {
            get
            {
                return z_type;
            }
            set
            {
                z_type = value;
            }
        }
        public string Voice
        {
            get
            {
                return z_voice;
            }
            set
            {
                z_voice = value;
            }
        }
        public int Respawns
        {
            get
            {
                return z_respawns;
            }
            set
            {
                z_respawns = value;
            }
        }
        public int Health
        {
            get
            {
                return z_attribute.Health;
            }
            set
            {
                z_attribute.Health = value;
            }
        }
        public int Damage
        {
            get
            {
                return z_attribute.Damage;
            }
            set
            {
                z_attribute.Damage = value;
            }
        }

    }
}
