using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Food
    {
        public int Quantity { get;}
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        
    }
}
