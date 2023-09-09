namespace LifeQuest
{
    public class TextDisplayHelper
    {
        private static int delayMilliseconds = 50; 

        public static void SetDelay(int milliseconds)
        {
            delayMilliseconds = milliseconds;
        }

        public static void SlowlyDisplayText(string text)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
