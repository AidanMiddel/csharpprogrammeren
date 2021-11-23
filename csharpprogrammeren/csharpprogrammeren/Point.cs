using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanScore
{
    internal class Point
    {
        private static float ball;

        public Point(float aBall)
        {
            ball = aBall;
        }

        public float GetBall()
        {
            return ball;
        }
    }
}
