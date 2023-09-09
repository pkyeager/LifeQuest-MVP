using System;

namespace LifeQuest
{
    class Player
    {
        // Player attributes
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int gender { get; set; }
        public string birthPlace { get; set; }
        public string stage { get; set; }
        public bool breastfeeding { get; set; }
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
        public Player(string firstName, string lastName, string gender)
        {
            firstName = firstName;
            lastName = lastName;
            gender = gender;
            birthPlace = RollDiceForBirthPlace();
            stage = "Infancy and Early Childhood";
        }

        // Player methods
        // Roll dice for birthplace
        private string RollDiceForBirthPlace()
        {

        }

        public string TransitionToNextStage()
        {

        }

    }
}