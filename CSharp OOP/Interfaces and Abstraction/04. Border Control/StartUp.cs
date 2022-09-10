using System;
using System.Collections.Generic;

namespace PersonInfo

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<string> IDs = new List<string>();
            while (command[0]!="End")
            {
                if (command.Length==2)
                {
                    Robot robot = new Robot(command[0],command[1]);
                    IDs.Add(robot.Id);
                }
                else if (command.Length==3)
                {
                    Citizen citizen = new Citizen(command[0], int.Parse(command[1]), command[2]);
                    IDs.Add(citizen.Id);
                }
                command = Console.ReadLine().Split();
            }
            string code = Console.ReadLine();
            for (int i = 0; i < IDs.Count; i++)
            {
                if (IDs[i].EndsWith(code))
                {
                    Console.WriteLine(IDs[i]);
                }
            }
        }
    }
}
