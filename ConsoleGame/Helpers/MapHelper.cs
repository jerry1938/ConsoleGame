using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Helpers
{
    class MapHelper
    {
        public string Map()
        {
            string path = @"..\..\..\..\map1.txt";
            string map = File.ReadAllText(path);
            return map;
        }
    }
}
