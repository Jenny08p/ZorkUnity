﻿using System;
using System.Collections.Generic;
using System.Text;
using Zork_Common;

namespace Zork_Game
{
    class ConsoleOutputService : IOutputService
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string value)
        {
            Console.Write(value);
        }

        public void Write(object value)
        {
            Write(value.ToString());
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
           
        }

        public void WriteLine(object value)
        {
            WriteLine(value.ToString());
        }

    }
}
