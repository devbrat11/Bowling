using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling.Library;
using Bowling.Printer;
using Bowling.InputAlley;

namespace Bowling.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAlley alleyObjects = new TestAlley();
            int[] numberOfBottlesFallInEachThrow = new int[3];
            int numberOfThrow = 3;
            int count = 0;
            Game game = new Game();
            AlleyPrinter printer = new AlleyPrinter();
            while (count < numberOfThrow)
            {
                game = new Game(alleyObjects.GetInputAlley(),(count+1));
                printer = new AlleyPrinter(game);
                game.Bowling();
                System.Threading.Thread.Sleep(1000);
                count++;
            }
            game.CalculateScore();
            printer.DisplayScore();
        }
    }
}

