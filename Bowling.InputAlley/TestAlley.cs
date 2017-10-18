using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling.Library;

namespace Bowling.InputAlley
{
    public class TestAlley
    {
        Point FilPoint = new Point();
        Boundary[] CloseBound = new Boundary[5];
        Boundary Boundary = new Boundary(false);
        Space[] CellSpaces = new Space[5];
        BowlingPins[] AlleyPins1 = new BowlingPins[5];
        BowlingPins[] AlleyPins2 = new BowlingPins[5];

        public Object[,] GetInputAlley()
        {
            AlleyObjectsInitialisation();
            return new Object[,]
                {
                    {FilPoint,CloseBound,FilPoint},
                    {Boundary,AlleyPins1,Boundary},
                    {Boundary,AlleyPins2,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                    {Boundary,CellSpaces,Boundary},
                };

        }

        private void AlleyObjectsInitialisation()
        {
            for (int i = 0; i < AlleyPins1.Count(); i++)
            {
                AlleyPins1[i] = new BowlingPins(false);
            }
            for (int i = 0; i < AlleyPins2.Count(); i++)
            {
                AlleyPins2[i] = new BowlingPins(false);
            }
            for (int i = 0; i < CellSpaces.Count(); i++)
            {
                CellSpaces[i] = new Space();
            }
            for (int i = 0; i < CloseBound.Count(); i++)
            {
                CloseBound[i] = new Boundary(false);
            }
        }
       
        
    }
}
