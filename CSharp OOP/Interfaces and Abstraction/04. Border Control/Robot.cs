using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IRobot
    {
        public string model;
        public string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get => model; set => model=value; }
        public string Id { get => id; set => id=value; }
    }
}
