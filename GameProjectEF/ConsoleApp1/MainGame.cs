using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MainGame
    {
        public bool[,] AllPossitions = new bool[81, 26];
        Random randomShape = new Random();
        List<Shape> shapeList = new List<Shape>(14);
        public int MyPoints { get; set; } = 0;
        public int count { get; set; } = 0;
        public bool Chack { get; set; }
        public int trys { get; set; } = 0;
        public MainGame()
        {
            this.count = 2;/*randomShape.Next(3, 6);*/
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
                    try
                    {
                        Ball ball = new Ball();
                        int XBall = randomShape.Next(1, 79);
                        int YBall = randomShape.Next(1, 24);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(XBall, YBall);
                        Console.Write(ball.MyChar);
                        while (AllPossitions[XBall, YBall] == false)
                        {
                            AllPossitions[XBall, YBall] = true;
                            ball.BallMove(ref XBall, ref YBall);
                            MyPoints++;
                        }
                        count++;
                    }
                    catch
                    {
                        trys = 0;
                        count++;
                        continue;
                    }
                }
                else
                {
                    AllPossitions.clearArray();
                    trys++;
                    continue;
                }
            }
            if (count == 15 || trys == 30)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"this is the END of the GAME\n this is your points: {MyPoints}");
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
