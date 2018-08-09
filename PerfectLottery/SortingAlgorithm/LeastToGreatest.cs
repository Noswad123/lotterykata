using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    class LeastToGreatest:ISortingAlgorithm
    {
        public List<int> Sort(List<int> lotteryNumbers)
        {
            lotteryNumbers.Sort();
            return lotteryNumbers;
        }
    }
}
