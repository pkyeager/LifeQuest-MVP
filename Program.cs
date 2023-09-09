using System;
using System.Threading;

namespace LifeQuest
{
    class Game
    {

        private static int delayMilliseconds = 50; // init delay to 50ms


        static void Main(string[] args) // entry point for program
        {
            Game game = new Game();
            game.StartGame();
        }

        public void StartGame() // method to start the game
        {
            SetOutputDelay(delayMilliseconds); // set the delay for text output
            TextDisplayHelper.SlowlyDisplayText("Welcome to LifeQuest!");
            TextDisplayHelper.SlowlyDisplayText("Press any key to start the game. Have fun!");
            Console.ReadKey();
            Player player = new Player();
            player.createPlayer();
        }

        public void SetOutputDelay(int milliseconds) // method to set the delay for text output
        {
            delayMilliseconds = milliseconds; // set the delay to the value passed in
        }


    }
}
