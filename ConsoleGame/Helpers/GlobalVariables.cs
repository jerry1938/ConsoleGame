using ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Helpers
{
    class GlobalVariables
    {
        public static PlayerStats PlayerStats = new();
        public static char playerPrefix = '@';

        public static string map = new MapHelper().Map();
    }
}
