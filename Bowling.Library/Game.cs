using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{
    public class Game
    {
        public int[] ThrowScore = new int[3];
        public int CalculateScore(int[] numberOfBottlesFallen)
        {
            int Score = 0;
            bool perfectHit = false;
            for (int i = 0; i < numberOfBottlesFallen.Count(); i++)
            {
                if (numberOfBottlesFallen[i] == 10 && perfectHit != true)
                {
                    if (i == 1) Score = Score + 10;
                    else if (i == 2) Score = Score - 3;
                    else Score = Score - 6;
                    perfectHit = true;
                }
                else if (numberOfBottlesFallen[i] < 10 && numberOfBottlesFallen[i] > 6)
                {
                    Score = Score + 2;
                }
                else if (numberOfBottlesFallen[i] < 7 && numberOfBottlesFallen[i] > 0)
                {
                    Score = Score + 1;
                }
                ThrowScore[i] = Score;
            }
            return Score;
        }
    }
}
