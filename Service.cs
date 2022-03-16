using System;

namespace GuessingGameDemo
{
    internal class Service
    {
        private readonly Random _random = new Random();
        // TODO: Duplicate guessing

        public int GuessCount { get; set; }
        public int TargetNum { get; private set; }

        // We just keep this to report on it with the View as we run in Startup
        public int MaxNum { get; private set; }

        public void CreateRandomNumber(int maxVal)
        {
            MaxNum = maxVal;
            TargetNum = _random.Next(1, MaxNum + 1);
        }
    }
}
