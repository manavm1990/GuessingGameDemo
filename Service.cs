using System;
namespace GuessingGameDemo
{
    public class Service
    {
        private readonly Random _random = new Random();
        // TODO: Duplicate guessing

        public int GuessCount { get; set; }
        public int TargetNum { get; private set; }
        public int MaxNum { get; private set; }

        public void CreateRandomNumber(int maxVal)
        {
            MaxNum = maxVal;
            TargetNum = _random.Next(1, MaxNum + 1);
        }
    }
}
