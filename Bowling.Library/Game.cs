﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Library
{
    public class Game
    {
        static public int TotalScore { get; private set; }
        static public List<int> numberOfBottlesFallInEachThrow = new List<int>();
        static public List<int> ThrowScore = new List<int>();
        public int ThrowNumber { get; set; }

        public Alley alley;
        public Ball ball;
       
        public Game() { }
        public Game(Object[,] alleyObjects)
        {
            alley = new Alley(alleyObjects);
            ball = new Ball(alley);
        }
        public int Bowling()
        {
            ball.ThrowBall();
            numberOfBottlesFallInEachThrow.Add(ball.NumberOfBottlesFall);
            return ball.NumberOfBottlesFall;
        }

        public void  CalculateScore()
        {
            int Score;
            bool perfectHit = false;
            int chance = 1;
            foreach (var value in numberOfBottlesFallInEachThrow)
            {
                Score = 0;
                if (value == 10 && perfectHit != true)
                {
                    if (chance == 1) Score = Score + 10;
                    else if (chance == 2) Score = Score - 3;
                    else Score = Score - 6;
                    perfectHit = true;
                }
                else if (value < 10 && value > 6)
                {
                    Score = Score + 2;
                }
                else if (value < 7 && value > 0)
                {
                    Score = Score + 1;
                }
                TotalScore = TotalScore + Score;
                ThrowScore.Add(Score);
                chance++;
            }
            
        }
    }
}
