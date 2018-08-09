using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    interface ISortingAlgorithm
    {
        List<int> Sort(List<int> lotteryNumbers);
    }
}
