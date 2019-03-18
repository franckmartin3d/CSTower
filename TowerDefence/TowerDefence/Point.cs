using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point (int x, int y)
        {
            x = X;
            y = Y;
        }
        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquare = xDiff * xDiff;
            int yDiffSquare = yDiff * yDiff;

            return Math.Sqrt(xDiffSquare + yDiffSquare);

        }
    }
}
