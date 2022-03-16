using System;

namespace GuessingGameDemo
{
    internal static class View
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int GetGuess(int maxNum)
        {
            return Validation.PromptUser4Int("Enter your guess: ", 1, maxNum);
        }

        public static int GetMaxNum()
        {
            return Validation.PromptUser4Int("Enter the max number to guess.");
        }
    }
}
