using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLottery
{
    public class ClassLottery
    {
        List<int> LotteryNumbers;

        public ClassLottery()
        {
            LotteryNumbers = new List<int>();
        }

        public ClassLottery(List<int> lotteryNumbers)
        {
            this.LotteryNumbers = lotteryNumbers;
        }      

        public List<int> SortLotteryNumbers()
        {
            LotteryNumbers.Sort();
            return LotteryNumbers;
        }

        public void DrawNumber(int RandomNumber)
        {
            LotteryNumbers.Add(RandomNumber);
        }

        public void DrawNumber()
        {
            var randomNumber = new Random();
            LotteryNumbers.Add(randomNumber.Next(59));
        }
    }
}
