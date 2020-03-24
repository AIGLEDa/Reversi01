using ReversiLibrary;
using System;


namespace ReversiClient
{
    class Program
    {

        private static void DrawLine()
        {
            Console.Write("   ");
            for(int i = 0; i<Game.Size; i++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }
        static void Main(string[] args)
        {
            Game game = new Game();

            Console.Write("   ");

            for(int col = 0; col<Game.Size; col++)
            {
                Console.Write($"  { (Char)('A' + col) } ");
            }
            Console.WriteLine("");

            for(int  row = 0; row<Game.Size; row++)
            {
                DrawLine();
                Console.Write($" {row+1} ");
                for(int col = 0; col<Game.Size; col++)
                {
                    var tile = '?';
                    switch(game.GetTile(col, row))
                    {
                        case Game.Empty: tile = ' '; break;
                        case Game.Black: tile = 'x'; break;
                        case Game.White: tile = 'o'; break;
                    }
                    Console.Write($"| { tile } ");
                }
                Console.WriteLine("|");
            }
/*
            for (int j = 0; j < Game.Size; j++)
            {
                
                //Console.Write("*---*");
                for (int i = 0; i < Game.Size; i++)
                {
                    Console.Write("+-+");
                }
                Console.Write("\n");

                for (int i = 0; i < Game.Size; i++)
                {
                    if(game.GetTile(i, j) == 0)
                    {
                        Console.Write("| |");
                        
                    }

                    if (game.GetTile(i, j) == -1)
                    {
                        Console.Write("|*|");

                    }

                    if (game.GetTile(i, j) == 1)
                    {
                        Console.Write("|0|");

                    }
                    //Console.Write($"|{game.GetTile(i, j)}|");
                    // Console.Write("+---+");
                }
                Console.Write("\n");
            }

    */


        }
    }
}
