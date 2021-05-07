using ConsoleGame.Player;
using ConsoleGame.Screen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Game
    {
        public void Start()
        {
            ScreenHandler screenHandler = new(100, 40);
            screenHandler.ScreenSettings();
            screenHandler.PrintMap();
            Movement movement = new();
            movement.Move();
        }
    }
}
