// Work from "Programming paradigms.docx"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationTest
{
    public class Attribute
    {
        private int a_health, a_stamina, a_damage;

        public Attribute(int health, int stamina, int damage)
        {
            a_health = health;
            a_stamina = stamina;
            a_damage = damage;
        }

        public int Health
        {
            get
            {
                return a_health;
            }
            set
            {
                a_health = value;
            }
        }
        public int Stamina
        {
            get
            {
                return a_stamina;
            }
            set
            {
                a_stamina = value;
            }
        }
        public int Damage
        {
            get
            {
                return a_damage;
            }
            set
            {
                a_damage = value;
            }
        }

    }
}
