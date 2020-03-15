using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodGenerator
    {
        public static Point Food;
        public static void GenerateNewFood() {
            var xx = new Random();
            int x =xx.Next(1,49);
            var yy = new Random();
            int y = yy.Next(1,20);
            Food = new Point(x,y,'@');
            Food.Draw();
        }
    }
}
