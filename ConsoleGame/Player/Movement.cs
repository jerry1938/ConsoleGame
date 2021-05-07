using ConsoleGame.Helpers;
using ConsoleGame.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    class Movement
    {
        public void Move()
        {
            ScreenHandler screenHandler = new();
            CollisionHelper collisionHelper = new();

            while (true)
            {
                ConsoleKey pressedKey;
                if (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey().Key;
                }
                else
                {
                    pressedKey = ConsoleKey.NoName;
                }

                switch (pressedKey)
                {
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (!collisionHelper.CheckCollision(1, 0))
                        {
                            GlobalVariables.PlayerStats.XPosition++;
                            screenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (!collisionHelper.CheckCollision(-1, 0))
                        {
                            GlobalVariables.PlayerStats.XPosition--;
                            screenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (!collisionHelper.CheckCollision(0, 1))
                        {
                            GlobalVariables.PlayerStats.YPosition++;
                            screenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (!collisionHelper.CheckCollision(0, -1))
                        {
                            GlobalVariables.PlayerStats.YPosition--;
                            screenHandler.PrintMap();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
