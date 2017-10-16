using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateTimeLib
{
    public class Game
    {
        private ITimeProvider timeProvider;
        private DateTime startTime;
        private int secondsToPlay;
        public Game(ITimeProvider timeProvider, int SecondsToPlay)
        {
            this.timeProvider = timeProvider;
            startTime = timeProvider.Now;
            secondsToPlay = SecondsToPlay;
        }

        public bool GameOver {
            get
            {
                return (timeProvider.Now - startTime).TotalSeconds >= secondsToPlay;
            }
        }
    }
}
