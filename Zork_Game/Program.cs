
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Zork_Common;


namespace Zork_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Game game = Game.LoadFromFile(gameFilename, output, input);
           
            
            while (game.IsRunning)
            {
                output.Write(">");
                input.ProcessInput();
            }

            output.WriteLine("Thanks for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }

}


