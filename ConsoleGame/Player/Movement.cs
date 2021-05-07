using ConsoleGame.Helpers;
using ConsoleGame.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Player
{
    internal static class Movement
    {
        public static void Move()
        {
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
                        if (!CollisionHelper.CheckCollision(1, 0))
                        {
                            GlobalVariables.PlayerStats.XPosition++;
                            ScreenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (!CollisionHelper.CheckCollision(-1, 0))
                        {
                            GlobalVariables.PlayerStats.XPosition--;
                            ScreenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (!CollisionHelper.CheckCollision(0, 1))
                        {
                            GlobalVariables.PlayerStats.YPosition++;
                            ScreenHandler.PrintMap();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (!CollisionHelper.CheckCollision(0, -1))
                        {
                            GlobalVariables.PlayerStats.YPosition--;
                            ScreenHandler.PrintMap();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
