using ConsoleGame.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Screen
{
    internal class ScreenHandler
    {
        public ScreenHandler() { }
        public ScreenHandler(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; } = 100;
        public int Height { get; set; } = 40;
        public void ScreenSettings()
        {
            Console.CursorVisible = false;
            Console.BufferWidth = Console.WindowWidth = Width;
            Console.BufferHeight = Console.WindowHeight = Height;
        }

        public static void PrintMap()
        {
            int xPlayerPos = GlobalVariables.PlayerStats.XPosition;
            int yPlayerPos = GlobalVariables.PlayerStats.YPosition;

            string[] map = GlobalVariables.map.Split(Environment.NewLine);
            char[][] mapCharacters = map.Select(item => item.ToArray()).ToArray();

            Console.ForegroundColor = ConsoleColor.Black;
            // Row 1
            Console.SetCursorPosition(46, 14);
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = -3; i < 4; i++)
            {
                Console.Write(mapCharacters[yPlayerPos - 4][xPlayerPos + i]);
            }

            // Row 2
            Console.SetCursorPosition(46, 15);
            Console.Write(mapCharacters[yPlayerPos - 3][xPlayerPos - 4]);
            Console.Write(mapCharacters[yPlayerPos - 3][xPlayerPos - 3]);
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = -2; i < 3; i++)
            {
                Console.Write(mapCharacters[yPlayerPos - 3][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos - 3][xPlayerPos + 3]);
            Console.Write(mapCharacters[yPlayerPos - 3][xPlayerPos + 4]);

            // Row 3
            Console.SetCursorPosition(46, 16);
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos - 4]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos - 3]);
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos - 2]);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = -1; i < 2; i++)
            {
                Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos + 2]);
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos + 3]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos - 2][xPlayerPos + 4]);

            // Row 4
            Console.SetCursorPosition(46, 17);
            Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos - 4]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos - 3]);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = -2; i < 3; i++)
            {
                Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos + 3]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos - 1][xPlayerPos + 4]);

            // Row 5
            Console.SetCursorPosition(46, 18);
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos - 4]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos - 3]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos - 2]);
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos - 1]);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write('@');
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos + 1]);
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos + 2]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos + 3]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos][xPlayerPos + 4]);

            // Row 6
            Console.SetCursorPosition(46, 19);
            Console.Write(mapCharacters[yPlayerPos + 1][xPlayerPos - 4]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos + 1][xPlayerPos - 3]);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = -2; i < 3; i++)
            {
                Console.Write(mapCharacters[yPlayerPos + 1][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos + 1][xPlayerPos + 3]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos + 1][xPlayerPos + 4]);

            // Row 7
            Console.SetCursorPosition(46, 20);
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos - 4]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos - 3]);
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos - 2]);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = -1; i < 2; i++)
            {
                Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos + 2]);
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos + 3]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos + 2][xPlayerPos + 4]);

            // Row 8
            Console.SetCursorPosition(46, 21);
            Console.Write(mapCharacters[yPlayerPos + 3][xPlayerPos - 4]);
            Console.Write(mapCharacters[yPlayerPos + 3][xPlayerPos - 3]);
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = -2; i < 3; i++)
            {
                Console.Write(mapCharacters[yPlayerPos + 3][xPlayerPos + i]);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(mapCharacters[yPlayerPos + 3][xPlayerPos + 3]);
            Console.Write(mapCharacters[yPlayerPos + 3][xPlayerPos + 4]);

            // Row 9
            Console.SetCursorPosition(46, 22);
            Console.Write(" ");
            for (int i = -3; i < 4; i++)
            {
                Console.Write(mapCharacters[yPlayerPos + 4][xPlayerPos + i]);
            }
        }
    }
}
