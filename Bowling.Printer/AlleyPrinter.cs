using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling.Library;

namespace Bowling.Printer
{
    public class AlleyPrinter
    {
        Alley _alley;
        Ball _ball;
        public AlleyPrinter(Alley alley, Ball ball)
        {
            _alley= alley;
            _ball = ball;
            _ball.Move+=()=>PrintCurrentState();
            _ball.Hit += () =>
            {
                _alley.BottlesHitted();
                Console.Clear();
                Display();
                SetSolvedStatusPosition();
            };
        }

        private void PrintCurrentState()
        {
            Console.Clear();
            Display();
            PrintVisitedCell(_ball.LocationCell);
            System.Threading.Thread.Sleep(500);
        }

        private void PrintVisitedCell(int cellIndex)
        {
            Console.SetCursorPosition(3, cellIndex);
            Console.Write("*");
        }

        private void SetSolvedStatusPosition()
        {
            Console.SetCursorPosition(0, 13);
        }

        private void Display()
        {
            Object[,] inputAlley = _alley._inputObjects;
            for (int i = 0; i < inputAlley.GetLength(0); i++)
            {
                for (int j = 0; j < inputAlley.GetLength(1); j++)
                {
                    if (inputAlley[i, j] is Bottle[])
                    {
                        Bottle[] bottles = (Bottle[])inputAlley[i, j];
                        for(int x = 0;x<bottles.Count();x++)
                        {
                            if (bottles[x].IsHitted == false) Console.Write("#");
                            else Console.Write(" ");

                        }
                        
                    }
                    else if (inputAlley[i, j] is Point) Console.Write(" ");
                    else if (inputAlley[i, j] is Space[]) Console.Write("     ");
                    else if (inputAlley[i, j] is Boundary[])
                    {
                        if (i == 0) Console.Write("-----");
                        else if (i % 3 == 0) Console.Write("     ");

                    }
                    else if (inputAlley[i, j] is Boundary)
                    {
                        Console.Write("|");
                    }

                }
                Console.WriteLine();
            }
        }

    }

}
