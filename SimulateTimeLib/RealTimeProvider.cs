using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateTimeLib
{
    public class RealTimeProvider : ITimeProvider
    {
        public DateTime Now { get => DateTime.Now; set => throw new NotImplementedException(); }
    }
}
