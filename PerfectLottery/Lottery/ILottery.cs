using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    interface ILottery
    {
        List<int> LotteryNumbers { set; }
        ISortingAlgorithm BallSorter {  set; }
        void SimulateLottery();
    }
}
