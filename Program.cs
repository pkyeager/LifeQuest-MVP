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
            SlowlyDisplayText("Welcome to LifeQuest!");
            SlowlyDisplayText("Press any key to continue...");
            Console.ReadKey();
        }

        public void SetOutputDelay(int milliseconds) // method to set the delay for text output
        {
            delayMilliseconds = milliseconds; // set the delay to the value passed in
        }

        public void SlowlyDisplayText(string text) // method to slowly display text
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(delayMilliseconds); // sleep for the delay in milliseconds
            }

            Console.WriteLine();
        }
    }
}
