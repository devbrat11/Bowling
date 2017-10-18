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

        public int NumberOfBottlesFall { get; private set; }
        public int LocationCell { get; private set; }

        private bool IsBallHitPins
        {
            get
            {
                if (LocationCell <= 2 && LocationCell > 0) return true;
                else return false;
            }

        }

        private bool IsBallHitEndOfAlley
        {
            get
            {
                if (LocationCell == 1) return true;
                else return false;
            }
        }

        public Ball(Alley alley)
        {
            NumberOfBottlesFall = 0;
            _alley = alley;
            LocationCell = _alley.CurrentCellNumber;
        }

        public void ThrowBall()
        {
            while (!IsBallHitEndOfAlley)
            {
                BallMoved();
                if (IsBallHitPins) StrikePins();
            }
        }

        private void StrikePins()
        {
            NumberOfBottlesFall = NumberOfBottlesFall+_alley.PinAction();
            Hit();
        }

        private void BallMoved()
        {
            LocationCell--;
            _alley.BallMoved();
            Move();

        }

    }
}
