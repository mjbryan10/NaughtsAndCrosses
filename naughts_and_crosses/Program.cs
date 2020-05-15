using System;
using System.Collections.Generic;

namespace naughts_and_crosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
            Console.WriteLine("Game Over!");

        }
    }
}
