using ConsoleGame.Player;
using ConsoleGame.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal static class Game
    {
        public static void Start()
        {
            ScreenHandler screenHandler = new(100, 40);
            screenHandler.ScreenSettings();
            ScreenHandler.PrintMap();
            Movement.Move();
        }
    }
}
