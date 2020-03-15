using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public List<Point> Tail = new List<Point>();
        public Point Head;
        public Snake() {
            Head = new Point(10, 5, '*');
            Point z = new Point(Head.x-1,Head.y,'*');
            Tail.Add(z);
        }
        public void DrawSnake() {
            //голова
            Head.Draw();
            //хвост
            foreach (Point p in Tail)
            {
                p.Draw();
            }
        }
        public void GrowthUp() {
            int alpha = Tail.Count;
            Point s = new Point(Tail[alpha-1].x-1,Tail[alpha-1].y,'*');
            Tail.Add(s);    
        }
        public void Move() {
            Head.Clear();
            //копируем хвост
            List<Point> temp = new List<Point>();
            for (int i = 0;i<Tail.Count;i++) {
                Point copy = new Point(Tail[i].x,Tail[i].y,'*');
                temp.Add(copy);
            }
            //смещение всего на 1 пункт
            Tail[0] = Tail[0] + Head;
            for (int i = 1; i<Tail.Count;i++) {
                Tail[i].Clear();
                Tail[i] = Tail[i] + temp[i - 1];
            }
            //Head.y--;
            //DrawSnake();
        }
    }
}
