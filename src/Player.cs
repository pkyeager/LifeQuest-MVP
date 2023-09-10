using System;

namespace LifeQuest
{
    public class Player
    {
        // Player attributes
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string birthPlace { get; set; }
        public string stage { get; set; }
        public int lifeExpectancy { get; set; }
        public bool breastfeeding { get; set; }

        public bool vaccination { get; set; }
        public bool balancedDiet { get; set; }
        public bool doDrugs { get; set; }
        public bool graduatedHighSchool { get; set; }
        public bool earlyGameFitness { get; set; }
        public bool socialLife { get; set; }
        public bool careerSuccess { get; set; }
        public bool happyFamily { get; set; }
        public bool goodFinance { get; set; }
        public bool endGameFitness { get; set; }
        public bool endGameNutrition { get; set; }

        // Player constructor

        public Player()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            birthPlace = string.Empty;
            stage = "Infancy and Early Childhood";
        }


        public void createPlayer()
        {
            // Choose gender
            string gender = string.Empty;

            // While Null or Empty (no value)...
            while (string.IsNullOrEmpty(gender))
            {
                TextDisplayHelper.SlowlyDisplayText("Choose your gender (Male/Female): ");
                string genderInput = Console.ReadLine().Trim(); // Trim whitespace

                // Check if the input is "male" or "female" ignore case
                if (string.Equals(genderInput, "male", StringComparison.OrdinalIgnoreCase))
                {
                    gender = "Male";
                    lifeExpectancy = 80;
                }
                else if (string.Equals(genderInput, "female", StringComparison.OrdinalIgnoreCase))
                {
                    gender = "Female";
                    lifeExpectancy = 85;
                }
                else
                {
                    TextDisplayHelper.SlowlyDisplayText("Invalid input. Please enter 'Male' or 'Female'.");
                }
            }

            // At this point, 'gender' will contain a valid value ('Male' or 'Female')
            TextDisplayHelper.SlowlyDisplayText($"You selected {gender} as your gender.");


            // Ask for first name
            TextDisplayHelper.SlowlyDisplayText("What is your first name?");
            firstName = Console.ReadLine();

            // Ask for last name
            TextDisplayHelper.SlowlyDisplayText("What is your last name?");
            lastName = Console.ReadLine();

            // Roll dice for birthplace
            TextDisplayHelper.SlowlyDisplayText("God starts rolling the dice for your birthplace...");
            TextDisplayHelper.SlowlyDisplayText("..................................................");
            string birthPlace = RollDiceForBirthPlace();
            // int lifeExpectancyModifier = AdjustLifeExpectancyBasedOnBirthPlace(Player,birthPlace);
            // Player.lifeExpectancy += lifeExpectancyModifier;
            Console.WriteLine("Player created! Press any key to see your Character.");
            Console.ReadKey();
            // Display player information
            TextDisplayHelper.SlowlyDisplayText("Character created!");
            TextDisplayHelper.SlowlyDisplayText($@"Name: {firstName} {lastName}");
            TextDisplayHelper.SlowlyDisplayText($@"Gender:  {gender}");
            TextDisplayHelper.SlowlyDisplayText($@"Birthplace: {birthPlace}");
            TextDisplayHelper.SlowlyDisplayText($@"Your current Stage: {stage}");
            TextDisplayHelper.SlowlyDisplayText($@"Your current Life Expectancy: {lifeExpectancy}");
            TextDisplayHelper.SlowlyDisplayText("Press any key to continue as a Infant.");
            Console.ReadKey();
        }


        // Player methods

        // Roll dice for birthplace
        private string RollDiceForBirthPlace()
        {
            Random random = new Random();
            int roll = random.Next(1, 6); // Generates a random number between 1 and 5 (inclusive).

            switch (roll)
            {
                case 1:
                    return "Africa";
                case 2:
                    return "Asia";
                case 3:
                    return "Europe";
                case 4:
                    return "North America";
                case 5:
                    return "South America";
                default:
                    return "Unknown"; // Handle any unexpected rolls.
            }

        }

        // Adjust life expectancy based on birthplace
        // private int AdjustLifeExpectancyBasedOnBirthPlace(Player player,string birthPlace)
        // {
        //     int lifeExpectancyModifier = 0;

        //     switch (birthPlace.ToLower())
        //     {
        //         case "Africa":
        //             lifeExpectancyModifier += -5; // Example: Life expectancy is lower in Africa.
        //             break;
        //         case "Asia":
        //             lifeExpectancyModifier += -3; // Example: Life expectancy is slightly lower in Asia.
        //             break;
        //         case "Europe":
        //             lifeExpectancyModifier += 3; // Example: Life expectancy is higher in Europe.
        //             break;
        //         case "North America":
        //             lifeExpectancyModifier += 2; // Example: Life expectancy is slightly higher in North America.
        //             break;
        //         case "South America":
        //             lifeExpectancyModifier += 1; // Example: Life expectancy in South America.
        //             break;
        //         default:
        //             lifeExpectancyModifier += 0; // Default modifier if birthplace is unknown.
        //             break;
        //     }

        //     return lifeExpectancyModifier;
        // }




        // Don't need this method now 
        // public void Summary(Player player)
        // {
        //     TextDisplayHelper.SlowlyDisplayText("Summary of your life:");
        //     TextDisplayHelper.SlowlyDisplayText($@"{player.firstName} {player.lastName} You have 
        //     lived your life as you wanted. You were born in {player.birthPlace} and you have lived 
        //     until {player.lifeExpectancy} years old. As a child you were {player.breastfeeding} breastfed,");
        // }



        // public string TransitionToNextStage()
        // {

        // }

    }
}