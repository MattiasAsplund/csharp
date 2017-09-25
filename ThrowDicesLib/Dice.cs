using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowDicesLib
{
    public class Dice
    {
        private Random _random;
        private int _numberOfPoints;
        public Dice(Random random)
        {
            _random = random;
        }
        public int NumberOfPoints {
            get
            {
                return _numberOfPoints;
            }
        }

        public void Throw()
        {
            _numberOfPoints = _random.Next(1, 6);
        }
    }
}
