using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.IO
{
    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string value)
        {
            Console.Write(value);
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public void ResetStyle()
        {
            Console.ResetColor();
        }
    }
}
