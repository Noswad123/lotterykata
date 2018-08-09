using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectLottery
{
    class PerfectProgram
    {
        static void Main(string[] args)
        {
            
            var houstonLottery = new TexasLottery(new List<int>(),new GreatestToLeast());

            houstonLottery.SimulateLottery();
        }
    }
}
