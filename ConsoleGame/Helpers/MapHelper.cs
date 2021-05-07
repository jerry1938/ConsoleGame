using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Helpers
{
    internal static class MapHelper
    {
        public static string Map()
        {
            const string path = @"..\..\..\..\map1.txt";
            string map = File.ReadAllText(path);
            return map;
        }
    }
}
