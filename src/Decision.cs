using System.Collections.Generic;


namespace LifeQuest
{
    public class Decision
    {
        public string question { get; set; }
        public string yesText { get; set; }
        public int yesLifeExpectancyImpact { get; set; }
        public string yesDescription { get; set; }
        public string noText { get; set; }
        public int noLifeExpectancyImpact { get; set; }
        public string noDescription { get; set; }
    }
}