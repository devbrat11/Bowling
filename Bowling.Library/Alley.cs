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

        public int NumberOfBottlesFall { get; private set; }
        public Object[,] _inputObjects;
        public int CurrentCellNumber { get; private set; }

        public Alley(Object[,] inputObjects)
        {
            NumberOfBottlesFall = 0;
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

        public void BottlesHitted()
        {
            int numberOfBottlesHitted=0;
            Random random = new Random();
            Bottle[] bottles = (Bottle[])(cells[CurrentCellNumber]._cellObjects[1]);
            for(int i=0;i<bottles.Count();i++)
            {
                int test = random.Next(0,9);
                if (test % 2 == 0)
                {
                    bottles[i].BottleHitted();
                    numberOfBottlesHitted++;
                }
            }
            NumberOfBottlesFall = NumberOfBottlesFall + numberOfBottlesHitted;
        }

        public void BallMoved()
        {
            CurrentCellNumber--;
        }
    }
        
}
