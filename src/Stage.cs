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
            Decision decision = new Decision();
            TextDisplayHelper.SlowlyDisplayText("You are now in the End of Life stage.");
            TextDisplayHelper.SlowlyDisplayText("You are now old and ready to die. You are now ready to meet your creator.");
            decision.EndGameFitness(player);
            decision.EndGameNutrition(player);
            TextDisplayHelper.SlowlyDisplayText("Press any key to see the summary.");
            Console.ReadLine();
            TextDisplayHelper.SlowlyDisplayText($@"Summary:
            You died at the age of {player.lifeExpectancy}. You lived your life as you wanted. You were born in {player.birthPlace} and you have lived 
            until {player.lifeExpectancy} years old. As a child you were {player.breastfeeding} breastfed....");
        }

        // Method to load the decisions for a specific stage
        // public void  LoadDecisionsForStage(string stage)
        // {
        //     DecisionDataLoader dataLoader = new DecisionDataLoader();
        //     decisions = dataLoader.LoadDecisionsForStage(stage);
        // }
    }
}