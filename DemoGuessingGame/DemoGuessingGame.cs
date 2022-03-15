using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGuessingGame
{
    public class StartUp
    {
        private Service _service = new();
        
        public void Run()
        {
            int maxNum = View.GetMaxNum();
            _service.CreateRandomNumber(maxNum);
        }

        public void CheckGuess()
        {
            View.DisplayMessage("Guess a number between 1 and max number: ");
        }
    }
}
