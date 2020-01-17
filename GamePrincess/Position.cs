using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrincess
{
    class Position:ICloneable
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public object Clone()
        {
            return new Position(X, Y);
        }
        public static bool operator ==(Position p1, Position p2)
        {
            return (p1.X == p2.X && p1.Y == p2.Y);
        }
        public static bool operator !=(Position p1, Position p2)
        {
            return (p1.X != p2.X || p1.Y != p2.Y);
        }
    }
}
