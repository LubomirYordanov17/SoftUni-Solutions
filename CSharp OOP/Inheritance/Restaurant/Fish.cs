﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        private const int FishGrams = 22;

        public Fish(string name, decimal price)
            : base(name, price, FishGrams)
        {

        }
    }
}