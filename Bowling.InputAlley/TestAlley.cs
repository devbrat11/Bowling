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
        Bottle[] AlleyBotl1 = new Bottle[5];
        Bottle[] AlleyBotl2 = new Bottle[5];

        public Object[,] GetInputAlley()
        {
            AlleyObjectsInitialisation();
            return new Object[,]
                {
                    {FilPoint,CloseBound,FilPoint},
                    {Boundary,AlleyBotl1,Boundary},
                    {Boundary,AlleyBotl2,Boundary},
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
            for (int i = 0; i < AlleyBotl1.Count(); i++)
            {
                AlleyBotl1[i] = new Bottle(false);
            }
            for (int i = 0; i < AlleyBotl2.Count(); i++)
            {
                AlleyBotl2[i] = new Bottle(false);
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
