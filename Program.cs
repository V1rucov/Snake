using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Walls();
            FoodGenerator.GenerateNewFood();
            Snake Player = new Snake();
            Player.GrowthUp();
            Player.DrawSnake();
            bool IsCrashed = false;
            int Score = 0;

            while (true) {
                for (int i =0; i<Player.Tail.Count;i++) {
                    if (Player.Head==Player.Tail[i]) {
                        Console.WriteLine("Game over!");
                        Console.WriteLine("Your score is "+Score);
                        IsCrashed = true;
                    }
                }
                if (Player.Head.x == 0 || Player.Head.x == 49 || Player.Head.y == 0 || Player.Head.y == 20) { 
                    IsCrashed = true;
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Your score is " + Score);
                }
                if (IsCrashed) break;
                if (Player.Head==FoodGenerator.Food) {
                    FoodGenerator.GenerateNewFood();
                    Player.GrowthUp();
                    Score++;
                }
                var KeyType = Console.ReadKey();
                string alpha = KeyType.Key.ToString();
                switch (alpha)
                {
                    case "UpArrow":
                        Player.Move();
                        Player.Head.y--;
                        Player.DrawSnake();
                        break;
                    case "DownArrow":
                        Player.Move();
                        Player.Head.y++;
                        Player.DrawSnake();
                        break;
                    case "RightArrow":
                        Player.Move();
                        Player.Head.x++;
                        Player.DrawSnake();
                        break;
                    case "LeftArrow":
                        Player.Move();
                        Player.Head.x--;
                        Player.DrawSnake();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
