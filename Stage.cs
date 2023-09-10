using System;

namespace LifeQuest
{
    class Stage
    {
        // Infancy and Early Childhood
        public static void InfancyAndEarlyChildhoodStage()
        {
            TextDisplayHelper.SlowlyDisplayText("You are now in the Infancy and Early Childhood stage.");
            TextDisplayHelper.SlowlyDisplayText("You finished your first year of life. You are becoming an Adolescence.");
            TextDisplayHelper.SlowlyDisplayText("Press any enter to continue.");
            Console.ReadLine();
        }

        // Adolescence
        public static void AdolescenceStage()
        {
            TextDisplayHelper.SlowlyDisplayText("You are now in the Adolescence stage.");
            TextDisplayHelper.SlowlyDisplayText("Now you are becoming an Adult. You are feeling like one of them.");
            TextDisplayHelper.SlowlyDisplayText("Press any enter to continue.");
            Console.ReadLine();

        }

        // Adulthood
        public static void AdulthoodStage()
        {
            TextDisplayHelper.SlowlyDisplayText("You are now in the Adulthood stage.");
            TextDisplayHelper.SlowlyDisplayText("You are now a full grown Adult. You are now ready to start your own family.");
            TextDisplayHelper.SlowlyDisplayText("Press any enter to continue.");
            Console.ReadLine();
        }

        // End of Life
        public static void EndOfLifeStage()
        {
            TextDisplayHelper.SlowlyDisplayText("You are now in the End of Life stage.");
            TextDisplayHelper.SlowlyDisplayText("You are now old and ready to die. You are now ready to meet your creator.");
            TextDisplayHelper.SlowlyDisplayText("Press any enter to continue.");
            Console.ReadLine();
        }
    }
}