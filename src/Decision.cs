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
            TextDisplayHelper.SlowlyDisplayText("As a baby, you can't make decisions. So, your parents will decide your first meal.");

            Random random = new Random();
            int randomIndex = random.Next(0, 2);

            if (randomIndex == 0)
            {
                player.breastfeeding = true;
                player.lifeExpectancy += 1;
                TextDisplayHelper.SlowlyDisplayText("Your parents opted for breastfeeding. You started your life as a milk connoisseur!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }
            else
            {
                player.breastfeeding = false;
                player.lifeExpectancy -= 1;
                TextDisplayHelper.SlowlyDisplayText("Your parents chose formula feeding. You missed out on the milk mustache!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }

            Console.ReadLine();
        }

        public void RandomVaccinationBaby(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("Your parents will make a crucial decision: to vaccinate or not to vaccinate.");

            Random random = new Random();
            int randomIndex = random.Next(0, 2);

            if (randomIndex == 0)
            {
                player.vaccination = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText("Your parents chose to vaccinate you. You've got that immunity champ status!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }
            else
            {
                player.vaccination = false;
                player.lifeExpectancy -= 2;
                TextDisplayHelper.SlowlyDisplayText("Your parents skipped the needles. You might catch a few more colds!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }

            Console.ReadLine();
        }

        public void RandomNutritionBaby(Player player)
        {
            TextDisplayHelper.SlowlyDisplayText("Your parents are debating your diet: healthy or not-so-healthy?");

            Random random = new Random();
            int randomIndex = random.Next(0, 2);

            if (randomIndex == 0)
            {
                player.balancedDiet = true;
                player.lifeExpectancy += 2;
                TextDisplayHelper.SlowlyDisplayText("Your parents went for a balanced diet. You're off to a nutritious start!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }
            else
            {
                player.balancedDiet = false;
                player.lifeExpectancy -= 2;
                TextDisplayHelper.SlowlyDisplayText("Your parents favored convenience over nutrition. Fast food it is!");
                TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
            }

            Console.ReadLine();
        }

        public void DoDrugs(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("As a teenager, peer pressure's on! Your friends want you to try drugs. What's your call?");

            do
            {
                TextDisplayHelper.SlowlyDisplayText("Type 'y' to experiment or 'n' to stay clean.");
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You went for it! The rebellious years begin. Rock 'n' roll!");
                    TextDisplayHelper.SlowlyDisplayText("Your body takes a hit, though. Long-term damage is the price.");
                    player.doDrugs = true;
                    player.lifeExpectancy -= 5;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You resisted temptation. You're a good kid!");
                    TextDisplayHelper.SlowlyDisplayText("Your health thanks you, and you gain a few extra years.");
                    player.doDrugs = false;
                    player.lifeExpectancy += 5;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void HighSchool(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("You're in High School now. Are you going to put in the effort to graduate or take it easy?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to aim for graduation or 'n' to cruise through.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You're hitting the books and aiming for that diploma!");
                    TextDisplayHelper.SlowlyDisplayText("Success is your middle name. You graduate and head to college.");
                    player.graduatedHighSchool = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("You take it easy in high school, no stress!");
                    TextDisplayHelper.SlowlyDisplayText("Life's not so smooth without a diploma, though. Finding a job is a challenge.");
                    player.graduatedHighSchool = false;
                    player.lifeExpectancy -= 4;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void EarlyFitness(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("You're not exactly a fitness guru. Time to decide: will you hit the gym?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to exercise or 'n' to stick with Netflix.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You're getting active! Muscles are forming, health is improving.");
                    player.earlyGameFitness = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Netflix it is! The couch is your best friend.");
                    TextDisplayHelper.SlowlyDisplayText("Your body might not thank you for this one.");
                    player.earlyGameFitness = false;
                    player.lifeExpectancy -= 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void SocialLife(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("Ready for some social adventures?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to make friends or 'n' to embrace solitude.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("You're a social butterfly! Friends galore!");
                    player.socialLife = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Solitude it is. Just you and your thoughts.");
                    TextDisplayHelper.SlowlyDisplayText("A bit lonely, but your introverted side thrives.");
                    player.socialLife = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void Career(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("Time to decide: career or no career?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to pursue a career or 'n' to skip the 9-to-5.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("Career it is! Climbing the ladder of success.");
                    player.careerSuccess = true;
                    player.lifeExpectancy += 3;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("No career path for you. Embracing the free spirit life!");
                    TextDisplayHelper.SlowlyDisplayText("Success is a foreign concept, but you're enjoying the journey.");
                    player.careerSuccess = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void Family(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("You've found a partner. Now, family or no family?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to start a family or 'n' to savor the single life.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("Family life it is! Diapers, sleepless nights, and endless love.");
                    player.happyFamily = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Solo journey, no strings attached.");
                    TextDisplayHelper.SlowlyDisplayText("You've chosen the path less chaotic.");
                    player.happyFamily = false;
                    player.lifeExpectancy -= 1;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void Finance(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("Time to manage those finances. Investing or spending?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to invest wisely or 'n' to embrace the spender's life.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("Investment guru in the making! Your wealth is on the rise.");
                    player.goodFinance = true;
                    player.lifeExpectancy += 3;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Money's here to spend! YOLO all the way.");
                    TextDisplayHelper.SlowlyDisplayText("Wallet's light, but you've got experiences to cherish.");
                    player.goodFinance = false;
                    player.lifeExpectancy -= 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void EndGameFitness(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("You're in your golden years. Time to exercise or not?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to stay fit or 'n' to embrace retirement fully.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("Senior fitness champion! Your body thanks you.");
                    player.endGameFitness = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("No more gym days. Relaxation is your new workout.");
                    TextDisplayHelper.SlowlyDisplayText("Your body may not be thrilled, but your soul is at peace.");
                    player.endGameFitness = false;
                    player.lifeExpectancy -= 3;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }

        public void EndGameNutrition(Player player)
        {
            string input;

            TextDisplayHelper.SlowlyDisplayText("You're in your golden years. Healthy eating or indulgence?");
            TextDisplayHelper.SlowlyDisplayText("Type 'y' to savor a balanced diet or 'n' to enjoy all your favorite treats.");

            do
            {
                input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    TextDisplayHelper.SlowlyDisplayText("Senior gourmet enthusiast! Your body's loving the nutrients.");
                    player.endGameNutrition = true;
                    player.lifeExpectancy += 2;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else if (input == "n")
                {
                    TextDisplayHelper.SlowlyDisplayText("Sweets and treats all the way. Life's too short for broccoli.");
                    TextDisplayHelper.SlowlyDisplayText("Your body might protest, but your taste buds are ecstatic.");
                    player.endGameNutrition = false;
                    player.lifeExpectancy -= 3;
                    TextDisplayHelper.SlowlyDisplayText("Press any key to continue.");
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            Console.ReadLine();
        }
    }


}

