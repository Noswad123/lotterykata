using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    class TexasLottery:ILottery
    {
        public List<int> LotteryNumbers { get; set; }
        public ISortingAlgorithm BallSorter { get; set; }
        readonly int LargestBall = 59;
        readonly int NumberOfDraws = 5;

        public TexasLottery(List<int> lotteryNumbers, ISortingAlgorithm sortingAlgorithm)
        {
            this.BallSorter = sortingAlgorithm;
            this.LotteryNumbers = lotteryNumbers;
        }

        public void SimulateLottery()
        {
            
            for (int i = 0; i < NumberOfDraws; i++)
            {
                Console.WriteLine("Number of Draws:" + i);
                DrawNumber(); 
                BallSorter.Sort(LotteryNumbers).ForEach(number => Console.Write(number + " "));
                Console.WriteLine("\n");
            }
        }

        public void DrawNumber()
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(LargestBall);
            while (LotteryNumbers.Contains(randomNumber))
            {
                randomNumber = randomNumberGenerator.Next(LargestBall);
            }
            LotteryNumbers.Add(randomNumber);
        }
    }
}
