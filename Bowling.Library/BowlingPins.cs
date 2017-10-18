using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{
    public class BowlingPins
    {
        public bool IsHitted { get; private set; }

        public BowlingPins(bool hitStatus)
        {
            IsHitted = hitStatus;
        }

        public void BottleHitted()
        {
            IsHitted = true;
        }
    }
}
