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
            TextDisplayHelper.SlowlyDisplayText("You are now in the Infancy and Early Childhood stage.");
            Decision decision = new Decision();
            decision.RandomFoodBaby(player);
            decision.RandomVaccinationBaby(player);
            decision.RandomNutritionBaby(player);
            TextDisplayHelper.SlowlyDisplayText("You finished your first years of life. You are becoming an Adolescence.");
            TextDisplayHelper.SlowlyDisplayText("Your parents gave their best to raise you. You are now ready to face the world.");
        }

        // Adolescence
        public static void AdolescenceStage(Player player)
        {
            Decision decision = new Decision();
            TextDisplayHelper.SlowlyDisplayText("You are now in the Adolescence stage.");
            TextDisplayHelper.SlowlyDisplayText("Now you are becoming an Adult. You are feeling like one of them.");
            decision.DoDrugs(player);
            decision.EarlyFitness(player);
            decision.SocialLife(player);
            decision.HighSchool(player);

        }

        // Adulthood
        public static void AdulthoodStage(Player player)
        {
            Decision decision = new Decision();
            TextDisplayHelper.SlowlyDisplayText("You are now in the Adulthood stage.");
            decision.Career(player);
            decision.Family(player);
            decision.Finance(player);
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
            TextDisplayHelper.SlowlyDisplayText("You are now in the End of Life stage.");
            TextDisplayHelper.SlowlyDisplayText("You are now old and ready to die. You are now ready to meet your creator.");
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