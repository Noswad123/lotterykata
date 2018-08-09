using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    class GreatestToLeast : ISortingAlgorithm
    {
        public List<int> Sort(List<int> lotteryNumbers)
        {
            lotteryNumbers.Sort();
            lotteryNumbers.Reverse();
            return lotteryNumbers;
        }
    }
}
