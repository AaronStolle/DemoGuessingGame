using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGuessingGame
{
    public class Service
    {
        private Random _random = new();

        //TODO: Duplicate Guessing Check
        private int maxNumber;

        public int GuessCount { get; set; }
        public int TargetNum { get; set; }
        public int MaxNum { get; set; }

       public void CreateRandomNumber(int maxVal)
        {
            MaxNum = maxVal;
            TargetNum = _random.Next(1, MaxNum+1);
        }
    }
}
