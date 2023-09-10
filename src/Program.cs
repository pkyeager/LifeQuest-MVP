using System;
using System.Threading;

namespace LifeQuest
{
    class Game
    {

        public static int delayMilliseconds = 25; // init delay var to 50ms


        static void Main(string[] args) // entry point for program
        {
            Game game = new Game();
            game.StartGame();
        }

        public void StartGame() // method to start the game
        {
            SetOutputDelay(delayMilliseconds); // set the delay for text output
            TextDisplayHelper.SlowlyDisplayText("Welcome to LifeQuest!");
            TextDisplayHelper.SlowlyDisplayText("Congratulations! You're about to embark on the journey of a lifetime.");
            TextDisplayHelper.SlowlyDisplayText("In this game, you'll navigate the twists and turns of life,");
            TextDisplayHelper.SlowlyDisplayText("making choices that will shape your destiny.");
            TextDisplayHelper.SlowlyDisplayText("Get ready to laugh, cry, and experience the rollercoaster that is life.");
            TextDisplayHelper.SlowlyDisplayText("Press any key to start the game. Have a blast!");
            Console.ReadKey();
            Player player = new Player();
            player.createPlayer();
            Stage stage = new Stage();
            Stage.InfancyAndEarlyChildhoodStage(player);
            Stage.AdolescenceStage(player);
            Stage.AdulthoodStage(player);
            Stage.EndOfLifeStage(player);
            // Player.Summary(player);
        }

        public void SetOutputDelay(int milliseconds) // method to set the delay for text output
        {
            delayMilliseconds = milliseconds; // set the delay to the value passed in
        }


    }
}
