using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mysnake
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game game = new Game();
            Console.SetWindowSize(35, 35);
            Console.SetBufferSize(35, 35);
            game.Start();

            while (game.isalive)
            {
                ConsoleKeyInfo bt = Console.ReadKey();
                game.Process(bt);
            }


       }
    }
}
