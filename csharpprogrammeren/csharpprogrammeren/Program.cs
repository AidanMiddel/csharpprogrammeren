using System;
using System.Collections.Generic;
using System.Linq;

namespace PacmanScore { 
    public class Program
    {
        public static void Main(string[] args)
        {
            Map thePoints = new Map();

            Point aPoint = new Point(1);

            thePoints.AddPoint(aPoint);
            
            foreach(Point p in thePoints.GetPoints())
            {
                Console.WriteLine(p.GetBall());
            }
        }
    }
}