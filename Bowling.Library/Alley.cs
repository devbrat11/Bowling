using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{
    public class Alley
    {
        Cell[] cells = new Cell[11];

        public Object[,] _inputObjects;
        public int CurrentCellNumber { get; private set; }

        public Alley(Object[,] inputObjects)
        {
            CurrentCellNumber = 10;
            int count = 0;
            _inputObjects = inputObjects;
            for (int i = 0; i < _inputObjects.GetLength(0); i++)
            {
                Object[] cellObjects = new Object[3];
                for (int j = 0; j < _inputObjects.GetLength(1); j++)
                {
                    cellObjects[j] = _inputObjects[i, j];
                }

                cells[count] = new Cell(cellObjects);
                count++;
            }
        }

        public int PinAction()
        {
            int numberOfPinsFall = 0;
            Random random = new Random();

            BowlingPins[] bowlingPins = (BowlingPins[])(cells[CurrentCellNumber]._cellObjects[1]);
            for (int i = 0; i < bowlingPins.Count(); i++)
            {
                int test = random.Next(0, 9);
                if (test % 2 == 0)
                {
                    bowlingPins[i].BottleHitted();
                    numberOfPinsFall++;
                }
            }


            return numberOfPinsFall;
        }

        public void BallMoved()
        {
            CurrentCellNumber--;
        }
    }

}
