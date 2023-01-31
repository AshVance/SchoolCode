namespace TextGame
{
    class Enemy
    {
        private bool hold_weapon;
        private bool headshot_only;
        private bool is_alive;
        private int health;

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

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
    }
}
