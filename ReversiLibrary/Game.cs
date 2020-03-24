using System;
using System.Collections.Generic;
using System.Text;

namespace ReversiLibrary
{
    public class Game
    {
        public const int Size = 8;
        public const int Empty = 0;
        public const int Black = 1;
        public const int White = -1;
        private int[,] _board = new int[8, 8];

        public Game()
        {
            _board[3, 3] = -1;
            _board[3, 4] = 1;
            _board[4, 3] = 1;
            _board[4, 4] = -1;
            
        }

        public int GetTile(int col, int row)
        {
            return _board[col, row];
        }


    }
}
