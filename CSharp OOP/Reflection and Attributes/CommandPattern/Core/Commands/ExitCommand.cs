using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Commands
{
    using Contracts;
    class ExitCommand : ICommand
    {
        private const int SuccesExitCode = 0;
        public string Execute(string[] args)
        {
            Environment.Exit(SuccesExitCode);
            return null;
        }
    }
}
