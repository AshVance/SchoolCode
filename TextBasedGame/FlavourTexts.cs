namespace TextGame
{
    class FlavourTexts
    {
        // Splash text - used while making the decision to fight etc.
        public static string[] splash_text = {
            "The alien's brain glows green through its forehead, you can't tell what it's thinking but it's *probably* thoughts of murder. Mean guy.",
            "The blaster resting in the alien's hand beeps angrily. You didn't even know a gun could sound angry but here you are proven wrong.",
            "The alien's eyes dart back and forth. He's closely studying every nuance of you looking for a weakness.",
            "The metal chestplate of the alien glistens in the sun, dazzling your eyes and with their gem-like beauty. The alien itself isn't so beautiful though."
        };

        // Text used to describe the player attacking the enemy.
        public static string[] ft_attack = {
            "You lunge at the enemy, catching its arm. It staggers back in pain.\n",
            "Your flying fist meets the enemy's chest, striking their windpipe and stunning them.",
            "You go for a kick, hitting them square in the face.\n",
            "Your flailing arm somehow collides with them, and somehow it even hurts them.\n" };

        // Text used to describe the player successfully dodging the enemy.
        public static string[] ft_dodge_success = {
            "You easily dodge the alien's quite frankly dreadful attack.",
            "You valiently jump out of the aliens grasp, stifling its attack.",
            "You swat the alien's hand away, in a somehow successful, yet still pathetic, attempt to stop its attack.",
            "You perform a sick backflip to dodge the alien's attack. Shame no one else saw it." };

        // Text used to describe the player failing to dodge the enemy.
        public static string[] ft_dodge_fail = {
            "Uh oh. The alien's strike catches you in the side.",
            "The alien's lunge meets your head. That's gotta hurt.",
            "Despite your best efforts, the alien's gangly arm manages to find you.",
            "Ouch. A laser to the chest is bound to leave a scratch." };

        // Text used to describe a successful counter.
        public static string[] ft_counter_success = {
            "Well done! A masterful dodge followed by a swift counter.",
            "A brave effort pays off, you smash a fist straight into its ugly face." };

        // Text used to describe a failed counter.
        public static string[] ft_counter_fail = {
        "Your counter missed. Pathetic attempt.",
        "Why did you even bother? That was never going to hit. "};

        // Text used to describe running.
        public static string[] ft_run = { };
    }
}
