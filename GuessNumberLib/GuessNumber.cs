using System;

namespace GuessNumberLib
{
    public class GuessNumber
    {
        private int numberToGuess;
        private int _triesMade;
        private int _lastGuess;
        public GuessNumber()
        {
            var random = new Random();
            numberToGuess = random.Next(1, 100);
        }
        public GuessNumber(int numberToGuess)
        {
            this.numberToGuess = numberToGuess;
        }
        public string Feedback {
            get
            {
                if (_triesMade == 0)
                    return "Guess a number between 1 and 100.";
                else if (_lastGuess < numberToGuess)
                    return "Guess higher.";
                else if (_lastGuess > numberToGuess)
                    return "Guess lower.";
                else
                    return $"You made it in {_triesMade} tries.";
            }
        }

        public int Tries {
            get
            {
                return _triesMade;
            }
        }

        public bool GameOver {
            get
            {
                return _lastGuess == numberToGuess;
            }
        }

        public void Guess(int guessedNumber)
        {
            _triesMade++;
            _lastGuess = guessedNumber;
        }
    }
}
