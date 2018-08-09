using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLottery
{
    public class DemoLottery
    {
        List<int> LotteryNumbers = new List<int>();
      
        public List<int> GetLotteryNumbers()
        {
            return LotteryNumbers;
        }
        public List<int> GetLotteryNumbers(int newNumber)
        {
            LotteryNumbers.Add(newNumber);
            int temp = 0;

            for (int i = 0; i < LotteryNumbers.Count; i++)
            {
                for (int j = 0; j < LotteryNumbers.Count - 1; j++)
                {
                    if (LotteryNumbers[j] > LotteryNumbers[j + 1])
                    {
                        temp = LotteryNumbers[j + 1];
                        LotteryNumbers[j + 1] = LotteryNumbers[j];
                        LotteryNumbers[j] = temp;
                    }
                }
            }
            return LotteryNumbers;
        }   
    }
}
