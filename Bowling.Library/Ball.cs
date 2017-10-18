using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{

    public class Ball
    {
        Alley _alley;
        public event Action Move;
        public event Action Hit;
        
        public int LocationCell { get; private set; }

        public Ball(Alley alley)
        {
            _alley = alley;
            LocationCell = _alley.CurrentCellNumber;
        }

        public void ThrowBall()
        {
            while (!IsBallHit())
            {
                BallMoved();
                if (LocationCell == 2) Hit();
            }
           // Hit();
           // BallMoved();
            Hit();

        }

        private bool IsBallHit()
        {
            if (LocationCell == 1) return true;
            else return false;
        }
        
        private void BallMoved()
        {
            LocationCell--;
            _alley.BallMoved();
            Move();

        }


    }
}
