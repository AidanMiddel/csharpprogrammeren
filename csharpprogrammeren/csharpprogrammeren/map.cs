using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanScore
{
    internal class Map
    {
        List<Point> balls;

        public Map()
        {
            balls = new List<Point>();
        }

        public void AddPoint(Point aPoint)
        {
            balls.Add(aPoint);
        }
        
        public List<Point> GetPoints()
        {
            return balls;
        }
    }
}
