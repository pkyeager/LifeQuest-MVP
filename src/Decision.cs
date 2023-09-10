// not using it yet

using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace LifeQuest
{
    public class DecisionData
    {
        public string lifeStage { get; set; }
        public List<Decision> decisions { get; set; }
    }
    public class Decision
    {
        public string question { get; set; }
        public string yesText { get; set; }
        public int yesLifeExpectancyImpact { get; set; }
        public string yesDescription { get; set; }
        public string noText { get; set; }
        public int noLifeExpectancyImpact { get; set; }
        public string noDescription { get; set; }
        // Methods for Decision (unclean way to do it)

        // random baby methods (because as a baby, you can't make decisions)

        public void RandomFoodBaby(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("As a baby, you can't make decisions. So, your parents will make a decision for you.");
            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            if (randomIndex == 0)
            {
                player.breastfeeding = true;
                player.lifeExpectancy += 1;
                TextDisplayHelper.SlowlyDisplayText("You are now breastfeeding.");
                TextDisplayHelper.SlowlyDisplayText("You are now healthier.");
                TextDisplayHelper.SlowlyDisplayText($@" Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
            else
            {
                player.breastfeeding = false;
                player.lifeExpectancy -= 1;
                TextDisplayHelper.SlowlyDisplayText("You are now not breastfeeding.");
                TextDisplayHelper.SlowlyDisplayText("You are now less healthier.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
        }
        public void RandomVaccinationBaby(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("As a baby, you can't make decisions. You parents will decide whether you will be vaccinated or not.");
            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            if (randomIndex == 0)
            {
                player.vaccination = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText("You are now vaccinated.");
                TextDisplayHelper.SlowlyDisplayText("You are now healthier.");
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
            else
            {
                player.vaccination = false;
                player.lifeExpectancy -= 2;
                TextDisplayHelper.SlowlyDisplayText("You are now not vaccinated.");
                TextDisplayHelper.SlowlyDisplayText("You are now less healthier.");
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
        }
        public void RandomNutritionBaby(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("As a baby, you can't make decisions. You parents will decide whether you will have a good nutrition or not.");
            Random random = new Random();
            int randomIndex = random.Next(0, 2);
            if (randomIndex == 0)
            {
                player.balancedDiet = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText("You are now having a good nutrition.");
                TextDisplayHelper.SlowlyDisplayText("You are now healthier.");
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
            else
            {
                player.balancedDiet = false;
                player.lifeExpectancy -= 2;
                TextDisplayHelper.SlowlyDisplayText("You are now not having a good nutrition.");
                TextDisplayHelper.SlowlyDisplayText("You are now less healthier.");
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
        }
        public void DoDrugs(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("As a teenager you are now facing a lot of decisions. You are now facing peer pressure. Your friends are asking you to do drugs.");
            TextDisplayHelper.SlowlyDisplayText("What will you do?");

            do
            {
                TextDisplayHelper.SlowlyDisplayText("Type 'y' to do drugs or 'n' to not do drugs.");
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now doing drugs. Drugs are bad for your health.");
                    TextDisplayHelper.SlowlyDisplayText("You are now less healthier.");
                    player.doDrugs = true;
                    player.lifeExpectancy -= 5;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not doing drugs. You are a good kid.");
                    TextDisplayHelper.SlowlyDisplayText("You are now healthier.");
                    player.doDrugs = false;
                    player.lifeExpectancy += 5;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");
        }

        public void HighSchool(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("You are now in High School. Do you want to try hard or don't even try to get graduated?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to try hard or 'n' to not try hard.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now trying hard to get graduated.");
                    TextDisplayHelper.SlowlyDisplayText("You are now more successful.");
                    player.graduatedHighSchool = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not trying hard to get graduated.");
                    TextDisplayHelper.SlowlyDisplayText("You are now less successful.");
                    player.graduatedHighSchool = false;
                    player.lifeExpectancy -= 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }

            } while (input != "y" && input != "n");
        }

        public void EarlyFitness(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("You look like you are not fit. Do you want to exercise?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to exercise or 'n' to not exercise.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now exercising.");
                    TextDisplayHelper.SlowlyDisplayText("You are now more fit.");
                    player.earlyGameFitness = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not exercising.");
                    TextDisplayHelper.SlowlyDisplayText("You are now less fit.");
                    player.earlyGameFitness = false;
                    player.lifeExpectancy -= 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
            } while (input != "y" && input != "n");

        }
        public void SocialLife(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("Are you interested in having a social life?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to have a social life or 'n' to not have a social life.");
            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now having a social life.");
                    TextDisplayHelper.SlowlyDisplayText("You have some friends.");
                    player.socialLife = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not having a social life.");
                    TextDisplayHelper.SlowlyDisplayText("You are a bit lonely.");
                    player.socialLife = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
            } while (input != "y" && input != "n");
        }
        // Methods for Adulthood Stage
        public void Career(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("You are at the point of your life where you have to decide if you want to have a career or not.");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to have a career or 'n' to not have a career.");
            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now having a career.");
                    TextDisplayHelper.SlowlyDisplayText("You are now more successful.");
                    player.careerSuccess = true;
                    player.lifeExpectancy += 3;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not having a career.");
                    TextDisplayHelper.SlowlyDisplayText("You are now less successful.");
                    player.careerSuccess = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
            } while (input != "y" && input != "n");
        }

        public void Family(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("You are at the point of your life where you have to decide if you want to have a family or not.");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to have a family or 'n' to not have a family.");
            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now having a family.");
                    TextDisplayHelper.SlowlyDisplayText("Family life can be stressful but also somehow beautiful.");
                    player.happyFamily = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are now not having a family.");
                    TextDisplayHelper.SlowlyDisplayText("You decide to be alone.");
                    player.happyFamily = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
            } while (input != "y" && input != "n");
        }

        public void Finance(Player player)
        {
            string input;
            TextDisplayHelper.SlowlyDisplayText("Financial is import and absolute crucial to prepare for the next phase of life.");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to start investing or 'n' to live paycheck to paycheck.");
            do
            {
                input = Console.ReadLine().ToLower().Trim();
                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You are staring investing.");
                    TextDisplayHelper.SlowlyDisplayText("You are rich.");
                    player.goodFinance = true;
                    player.lifeExpectancy += 3;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Money are there to spend for you. Yolo.");
                    TextDisplayHelper.SlowlyDisplayText("You are poor.");
                    player.goodFinance = false;
                    player.lifeExpectancy -= 2;
                    TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                    TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                    Console.ReadLine();
                }
            } while (input != "y" && input != "n");
        }

    // Methods for End of Life Stage

    public void EndGameFitness(Player player)
    {
        string input;
        TextDisplayHelper.SlowlyDisplayText("You are now old. Do you want to exercise?");
        TextDisplayHelper.SlowlyDisplayText("Type 'y' to exercise or 'n' to not exercise.");
        do 
        {
            input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                TextDisplayHelper.SlowlyDisplayText("You are now exercising.");
                TextDisplayHelper.SlowlyDisplayText("You are now more fit.");
                player.endGameFitness = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
            else if (input == "n")
            {
                TextDisplayHelper.SlowlyDisplayText("You are now not exercising.");
                TextDisplayHelper.SlowlyDisplayText("You are now less fit.");
                player.endGameFitness = false;
                player.lifeExpectancy -= 3;
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
        } while (input != "y" && input != "n");
    }

    public void EndGameNutrition(Player player)
    {
        string input;
        TextDisplayHelper.SlowlyDisplayText("You are now old. Do you want to have a good nutrition?");
        TextDisplayHelper.SlowlyDisplayText("Type 'y' to have a good nutrition or 'n' to not have a good nutrition.");
        do 
        {
            input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                TextDisplayHelper.SlowlyDisplayText("You are now having a good nutrition.");
                TextDisplayHelper.SlowlyDisplayText("You are now more healthier.");
                player.endGameNutrition = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
            else if (input == "n")
            {
                TextDisplayHelper.SlowlyDisplayText("You are now not having a good nutrition.");
                TextDisplayHelper.SlowlyDisplayText("You are now less healthier.");
                player.endGameNutrition = false;
                player.lifeExpectancy -= 3;
                TextDisplayHelper.SlowlyDisplayText($@"Your current life expectancy is {player.lifeExpectancy} years old.");
                TextDisplayHelper.SlowlyDisplayText("Press any key enter to continue.");
                Console.ReadLine();
            }
        } while (input != "y" && input != "n");
    }
    }


}

