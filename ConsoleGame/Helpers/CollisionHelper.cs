using ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Helpers
{
    internal static class CollisionHelper
    {
        public static bool CheckCollision(int xDirection, int yDirection)
        {
            string[] map = GlobalVariables.map.Split(Environment.NewLine);
            char[][] mapCharacters = map.Select(item => item.ToArray()).ToArray();

            return mapCharacters[GlobalVariables.PlayerStats.YPosition + yDirection]
                [GlobalVariables.PlayerStats.XPosition + xDirection] == '#';
        }
    }
}
