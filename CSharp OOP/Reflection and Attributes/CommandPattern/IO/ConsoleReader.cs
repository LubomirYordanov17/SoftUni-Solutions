using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.IO
{
    using Core;
    using Core.Contracts;
    using Contracts;
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();
            return line;
        }
    }
}
