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

        public AlleyPrinter() { }
        public AlleyPrinter(Game game)
        {
            _alley = game.alley;
            _ball = game.ball;
            _ball.Move += () => PrintCurrentState(game.ThrowNumber);
            _ball.Hit += () =>
            {
                Console.Clear();
                DisplayAlley();
                PrintThrowNumber(game.ThrowNumber);
                SetGameStatusPosition();
            };
        }

        public void DisplayScore()
        {
            int count=0;
            Console.WriteLine("Throw #   Number Of Pins Fall   ThrowScore");
            while(count<3)
            {
                Console.WriteLine("   "+(count+1)+"\t\t"+Game.numberOfBottlesFallInEachThrow.ElementAt(count)+
                    "\t\t  "+Game.ThrowScore.ElementAt(count));
                count++;
            }
            Console.WriteLine("\nTotal Score :" + Game.TotalScore);
        }

        private void PrintThrowNumber(int throwNumber)
        {
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Throw # "+throwNumber);
            
        }

        private void PrintCurrentState(int throwNumber)
        {
            Console.Clear();
            
            DisplayAlley();
            PrintThrowNumber(throwNumber);
            PrintBallPosition(_ball.LocationCell);
            System.Threading.Thread.Sleep(500);
        }

        private void PrintBallPosition(int cellIndex)
        {
            Console.SetCursorPosition(3, cellIndex);
            Console.Write("O");
        }

        private void SetGameStatusPosition()
        {
            Console.SetCursorPosition(0, 13);
        }

        private void DisplayAlley()
        {
            Object[,] inputAlley = _alley._inputObjects;
            for (int i = 0; i < inputAlley.GetLength(0); i++)
            {
                for (int j = 0; j < inputAlley.GetLength(1); j++)
                {
                    if (inputAlley[i, j] is BowlingPins[])
                    {
                        BowlingPins[] bottles = (BowlingPins[])inputAlley[i, j];
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
