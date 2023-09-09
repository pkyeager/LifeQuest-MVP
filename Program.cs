using System;
using System.Threading;

namespace LifeQuest
{
    class Game
    {
        private static int delayMilliseconds = 50;

        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
        }

        public void StartGame()
        {
            SetOutputDelay(delayMilliseconds);
            SlowlyDisplayText("Welcome to LifeQuest!");
            SlowlyDisplayText("Press any key to continue...");
            Console.ReadKey();
        }

        public void SetOutputDelay(int milliseconds)
        {
            delayMilliseconds = milliseconds;
        }

        public void SlowlyDisplayText(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(delayMilliseconds);
            }

            Console.WriteLine();
        }
    }
}
