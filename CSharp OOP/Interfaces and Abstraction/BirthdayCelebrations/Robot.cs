﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Robot : IRobot
    {
        public string model;
        public string id;
        public Robot(string model,string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get => model; set => model=value; }
        public string Id { get => id; set => id=value; }
    }
}
