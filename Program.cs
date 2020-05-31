using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    partial class Program
    {
        static volatile string alpha;
        static volatile Snake Player = new Snake();
        static volatile bool IsCrashed = false;
        public static int Score = 0;

        static void Main(string[] args)
        {
            int speed = 200;
            Walls();
            FoodGenerator.GenerateNewFood();
            Player.GrowthUp();
            Player.DrawSnake();

            Thread ChangeKeyy = new Thread(changeKey);
            ChangeKeyy.Start();

            while (!IsCrashed) {
                for (int i =0; i<Player.Tail.Count;i++) {
                    if (Player.Head==Player.Tail[i]) {
                        IsCrashed = true;
                        GameOver();
                    }
                }
                if(Player.Head.x==0 ||Player.Head.x==49 ||Player.Head.y==0 ||Player.Head.y==20){
                    IsCrashed = true;
                    GameOver();
                }
                if (Player.Head==FoodGenerator.Food) {
                    FoodGenerator.GenerateNewFood();
                    Player.GrowthUp();
                    Score++;
                    speed = speed -10;
                }
                Thread.Sleep(speed);
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
            GameOver();
        }
        static void changeKey(){
            while(!IsCrashed){

                var KeyType = Console.ReadKey();
                alpha = KeyType.Key.ToString();
            }
        }
        public static void GameOver(){
            Console.SetCursorPosition(10,10);
            Console.WriteLine("Game over!");
            Console.WriteLine("         Your score is "+Program.Score);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
