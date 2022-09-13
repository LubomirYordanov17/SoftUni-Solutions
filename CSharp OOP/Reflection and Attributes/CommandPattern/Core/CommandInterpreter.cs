using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core
{
    using Contracts;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] cmdSplit = args
               .Split();
            string cmdName = cmdSplit[0];
            string[] cmdArgs = cmdSplit.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type cmdType = assembly?
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{cmdName}Command" &&
                                     t.GetInterfaces().Any(i => i == typeof(ICommand)));
           

            object cmdInstance = Activator.CreateInstance(cmdType);

            MethodInfo executeMethod = cmdType
                .GetMethods()
                .First(m => m.Name == "Execute");
            string result = (string)executeMethod.Invoke(cmdInstance, new object[] { cmdArgs });

            return result;
        }
    }
}
