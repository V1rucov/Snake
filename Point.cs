using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char CH;

        public Point(int x, int y, char CH) {
            this.x = x;
            this.y = y;
            this.CH = CH;
        }
        private void DrawPoint(char CH) {
            Console.SetCursorPosition(x, y);
            Console.Write(CH);
        }
        public void Draw() {
            DrawPoint(CH);
        }
        public void Clear() {
            DrawPoint(' ');
        }

        public static Point operator +(Point a, Point b) {
            a.x = b.x;
            a.y = b.y;
            return a;
        }
        public static bool operator ==(Point a, Point b) {
            if (a.x == b.x && a.y == b.y)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Point a, Point b)
        {
            if (a.x != b.x && a.y != b.y)
            {
                return true;
            }
            else return false;
        }
    }
}
