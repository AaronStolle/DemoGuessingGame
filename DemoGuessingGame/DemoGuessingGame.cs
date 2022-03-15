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
        while (true)
        {
            if(CheckGuess()) break;
        }

    public void CheckGuess()
        {
            View.DisplayMessage($"Guess a number between 1 and {_service.MaxNum}: ");
            int userGuess = View.GetGuess(_service.MaxNum);

            //TODO: Update the guessCount
            _service.GuessCount++;

            //TODO: Check the guess with the number
            if (userGuess == _service.TargetNum)
            {
                View.DisplayMessage($@"You win! The number was
{_service.TargetNum} and it took {_service.GuessCount}");
                return true;
            }
            if (userGuess > _service.TargetNum)
            {
                View.DisplayMessage("Too Low.");
                return false;
            }

            View.DisplayMessage("Too high");
            return false;


        }
    }
}
