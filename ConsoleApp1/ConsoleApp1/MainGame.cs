using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MainGame
    {
        public bool[,] AllPossitions = new bool[81, 26];
        Random randomShape = new Random();
        List<Shape> shapeList = new List<Shape>(14);
        public int count { get; set; } = 0;
        public bool Chack { get; set; }
        public int trys { get; set; } = 0;
        public MainGame()
        {
            this.count = randomShape.Next(3, 6);
        }

        public void Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(81, 26);
            Console.ForegroundColor = ConsoleColor.White;

            while (count != 15 && trys != 30)
            {
                shapeList.Clear();
                AllPossitions.clearArray();
                Console.Clear();
                for (int i = 0; i < count; i++)
                {
                    int shapenum = randomShape.Next(1, 5);
                    switch (shapenum)
                    {
                        case 1:
                            shapeList.Add(new Line());
                            break;
                        case 2:
                            shapeList.Add(new Square());
                            break;
                        case 3:
                            shapeList.Add(new Rectangle());
                            break;
                        case 4:
                            shapeList.Add(new Triangular());
                            break;
                    }
                }

                Draw();
                if (Chack == true)
                {
                    Ball ball = new Ball();
                    int XBall = randomShape.Next(1, 79);
                    int YBall = randomShape.Next(1, 24);
                    while (AllPossitions[XBall, YBall] == false)
                    {
                        ball.BallMove(ref XBall, ref YBall);
                    }
                    count++;
                }
                else
                {
                    AllPossitions.clearArray();
                    trys++;
                    continue;
                }
            }
        }

        public void Draw()
        {
            foreach (var shape in shapeList)
            {
                shape.ChooseColor();
                shape.GenarateShape();
                Chack = AllPossitions.ShapeIsTher(shape.Size);

                if (Chack == false)
                {
                    return;
                }
            }
        }


    }
}
