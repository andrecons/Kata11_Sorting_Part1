using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata11_Sorting_Part1.Objects
{
    class Lottery
    {
        private int vMin;
        private int vMax;

        List<int> winnerRack = new List<int>();

        public Lottery(int inputMinValue, int inputMaxValue) 
        {
            this.vMin = inputMinValue;
            this.vMax = inputMaxValue;
        }

        public bool DrawOut()
        {
            Random rnd = new Random();
            int newBall = rnd.Next(vMin, vMax +1); // returns random integers >= 10 and < 20

            if (!IsContained(newBall))
            {
                winnerRack.Add(newBall);
                return true;
            }
            else
            {
                Console.WriteLine("the ball" + newBall + " has already been taken");
                return false;
            }

        }



        public bool IsContained(int newBall)
        {
            if (winnerRack.Contains(newBall)) 
            {
                return true;
            }
                
            else
            {
                return false;
            }
        }


        public void RackSort()
        {
            winnerRack.Sort();
        }

        public void RackPrint()
        {
            Console.WriteLine("\n");
            Console.Write("current sorted balls: ");
            foreach (int ball in winnerRack)
            {
                Console.Write(ball + " ");
            }
            Console.WriteLine("\n");
        }

    }
}
