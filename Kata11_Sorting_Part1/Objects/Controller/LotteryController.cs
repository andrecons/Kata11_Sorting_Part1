using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata11_Sorting_Part1.Objects.Controller
{
    static class LotteryController
    {
        private const int minValue = 0;
        private const int maxValue = 59;

        public static void Start(int ballsToDrawOut)
        {
            Lottery lottery = new Lottery(minValue, maxValue);

            for (int i = 0; i < ballsToDrawOut; i++)
            {
                while (!lottery.DrawOut()) { }
                
                lottery.RackSort();
                lottery.RackPrint();
            }
        }
    }
}
