using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeQuest
{
    public class Stage
    {

        // Attributes 
        // public string lifeStage { get; set; }
        // public static List<Decision> decisions { get; set; }

        // Constructor
        // public Stage()
        // {

        //     decisions = new List<Decision>();
        // }


        // Infancy and Early Childhood
        public static void InfancyAndEarlyChildhoodStage(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("You find yourself in the Infancy and Early Childhood stage.");

            Decision decision = new Decision();

            // Randomly determine food choice for infancy
            decision.RandomFoodBaby(player);

            // Randomly determine vaccination choice for infancy
            decision.RandomVaccinationBaby(player);

            // Randomly determine nutrition choice for infancy
            decision.RandomNutritionBaby(player);

            TextDisplayHelper.SlowlyDisplayText("You've survived your first years of life, and now you're growing into adolescence.");
            TextDisplayHelper.SlowlyDisplayText("Your parents did their best to raise you, and now it's time to face the world.");

            Console.ReadLine();
        }

        // Adolescence
        public static void AdolescenceStage(Player player)
        {
            Decision decision = new Decision();

            TextDisplayHelper.SlowlyDisplayText("You've entered the Adolescence stage.");
            TextDisplayHelper.SlowlyDisplayText("You're starting to feel like an adult and facing new challenges.");

            // Make choices for adolescence
            decision.DoDrugs(player);
            decision.EarlyFitness(player);
            decision.SocialLife(player);
            decision.HighSchool(player);

            Console.ReadLine();
        }

        // Adulthood
        public static void AdulthoodStage(Player player)
        {
            Decision decision = new Decision();

            TextDisplayHelper.SlowlyDisplayText("Welcome to the Adulthood stage.");
            TextDisplayHelper.SlowlyDisplayText("Life is calling, and you have important decisions to make.");

            // Make choices for adulthood
            decision.Career(player);
            decision.Family(player);
            decision.Finance(player);

            Console.ReadLine();
        }


        // End of Life
        public static void EndOfLifeStage(Player player)
        {
            string summary = $@"Summary:
    Congratulations on surviving until the ripe age of {player.lifeExpectancy}! You've lived your life to the fullest. You were born in {player.birthPlace} and made it all the way to {player.lifeExpectancy} years old.";

            if (player.breastfeeding)
            {
                summary += " Your early days were nourished by the magical elixir known as breast milk. You were a milk connoisseur!";
            }
            else
            {
                summary += " No breast milk for you! But hey, you still made it this far, so kudos!";
            }

            if (player.vaccination)
            {
                summary += " You also braved the needle and got vaccinated. Immunity champ!";
            }
            else
            {
                summary += " Needles and vaccines? Nah, not your thing. You lived life on the edge!";
            }

            if (player.balancedDiet)
            {
                summary += " Your taste buds danced with a balanced diet throughout your life. Healthy body, happy you!";
            }
            else
            {
                summary += " Fast food aficionado? Your diet might not have been the healthiest, but it was tasty!";
            }

            if (player.doDrugs)
            {
                summary += " Ah, the rebellious years! You dabbled in the art of doing drugs. Rock 'n' roll, right?";
            }
            else
            {
                summary += " A straight shooter, you steered clear of recreational substances. Clean living all the way!";
            }

            if (player.graduatedHighSchool)
            {
                summary += " You conquered high school! Graduation cap and all. Smarty pants!";
            }
            else
            {
                summary += " School's out forever! You took a different path, but it's all part of your unique journey.";
            }

            if (player.earlyGameFitness)
            {
                summary += " Early on, you embraced fitness like a true athlete. Pumping iron and breaking a sweat!";
            }
            else
            {
                summary += " Couch potato in your early years? Hey, you can't rush greatness!";
            }

            if (player.socialLife)
            {
                summary += " Your social life was epic! Parties, friends, and memories galore.";
            }
            else
            {
                summary += " Introvert or just focusing on other things? Your social life was uniquely you!";
            }

            if (player.careerSuccess)
            {
                summary += " You climbed the career ladder like a pro. CEO material!";
            }
            else
            {
                summary += " Career? Who needs it? You took a different path and had your own adventures.";
            }

            if (player.happyFamily)
            {
                summary += " Your family life was a true sitcom, full of love and laughter!";
            }
            else
            {
                summary += " Drama or solitude? Your family life had its quirks, just like any other.";
            }

            if (player.goodFinance)
            {
                summary += " Money management was your superpower! Financial wizardry!";
            }
            else
            {
                summary += " Wallet a bit leaky? You enjoyed the journey, not just the destination!";
            }

            if (player.endGameFitness)
            {
                summary += " In the final stretch, you focused on fitness. Aging like fine wine!";
            }
            else
            {
                summary += " No last-minute gym sessions? No problem, you were still fabulous!";
            }

            if (player.endGameNutrition)
            {
                summary += " In your golden years, you obsessed over nutrition. Aging like a health guru!";
            }
            else
            {
                summary += " Forgot the kale smoothies? Life is all about balance, after all!";
            }

            // Add a closing note
            summary += "\n\nNow, the curtains have closed, but your unique journey will always be remembered.";


            Decision decision = new Decision();
            TextDisplayHelper.SlowlyDisplayText("You find yourself in the End of Life stage.");
            TextDisplayHelper.SlowlyDisplayText("You're now old and ready to embark on your final journey.");
            TextDisplayHelper.SlowlyDisplayText("It's time to make some last choices that will determine your final moments.");
            decision.EndGameFitness(player);
            decision.EndGameNutrition(player);
            TextDisplayHelper.SlowlyDisplayText("Press any key to see the summary.");
            Console.ReadLine();
            TextDisplayHelper.SlowlyDisplayText(summary);
        }

        // Method to load the decisions for a specific stage
        // public void  LoadDecisionsForStage(string stage)
        // {
        //     DecisionDataLoader dataLoader = new DecisionDataLoader();
        //     decisions = dataLoader.LoadDecisionsForStage(stage);
        // }
    }
}