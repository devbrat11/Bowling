using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{
    public class Cell
    {
        public object[] _cellObjects = new Object[3];
        public Cell(Object[] cellObjects)
        {
            for(int i=0;i<cellObjects.Count();i++)
            {
                _cellObjects[i] = cellObjects[i];
            }
        }
    }
}
