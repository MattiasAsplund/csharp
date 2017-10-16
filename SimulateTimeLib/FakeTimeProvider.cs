using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateTimeLib
{
    public class FakeTimeProvider : ITimeProvider
    {
        public DateTime Now { get; set; }

        public void AddSeconds(int seconds)
        {
            Now = Now.AddSeconds(seconds);
        }
    }
}
