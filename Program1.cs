using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    partial class Program
    {
        static void Walls()
        {
            Console.SetWindowSize(50,21);
            int x = 0;
            int y = 0;
            Console.SetCursorPosition(x, y);
            //отрисовка верхней линии
            for (int i = 0; i < 50; i++)
            {
                Console.Write("#");
                x++;
            }
            x = 0;
            y = 0;
            //отрисовка нижней линии
            Console.SetCursorPosition(x, 20);
            for (int i = 0; i < 50; i++)
            {
                Console.Write("#");
                x++;
            }
            x = 0;
            y = 0;
            //отрисовка левой боковой линии
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("#");
                y++;
            }
            x = 0;
            y = 0;
            //отрисовка правой боковой линии
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(49, y);
                Console.Write("#");
                y++;
            }
        }
    }
}
