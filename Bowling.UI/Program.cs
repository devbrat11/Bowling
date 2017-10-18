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
            Alley alley ;
            Ball ball  ;
            while (count < numberOfThrow)
            {
                alley = new Alley(alleyObjects.GetInputAlley());
                ball = new Ball(alley);
                AlleyPrinter printer = new AlleyPrinter(alley, ball);
                ball.ThrowBall();
                numberOfBottlesFallInEachThrow[count] = alley.NumberOfBottlesFall;
                count++;
                Console.WriteLine("Throw # " + (count));
                Console.WriteLine("Number of Fallen Bottles: " + numberOfBottlesFallInEachThrow[count-1]);
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine("\nTotal Score :" + game.CalculateScore(numberOfBottlesFallInEachThrow));
           
        }
    }
}

