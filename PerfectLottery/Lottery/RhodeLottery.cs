using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    class RhodeLottery : ILottery
    {
        public List<int> LotteryNumbers { get; set; }
        public ISortingAlgorithm BallSorter { get; set ; }
        readonly int LargestBall = 59;
        readonly int NumberOfDraws = 7;

        public RhodeLottery(List<int> lotteryNumbers, ISortingAlgorithm sortingAlgorithm)
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
            LotteryNumbers.Add(randomNumberGenerator.Next(LargestBall));
        }
    }
}
