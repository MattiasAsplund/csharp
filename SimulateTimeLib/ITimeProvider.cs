using System;

namespace SimulateTimeLib
{
    public interface ITimeProvider
    {
        DateTime Now { get; set; }
    }
}
