using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.InputAlley
{
    public class Boundary
    {
        bool _hasOpening;

        public Boundary(bool hasOpening)
        {
            _hasOpening = hasOpening;
        }

        public bool HasOpening()
        {
            return _hasOpening;
        }
    }
}
