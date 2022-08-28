using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class GlobalConstants
    {
        
            public static string InvalidNameExceptionMessage = "Name cannot be empty";
            public static string InvalidMoneyExceptionMessage = "Money cannot be negative";
            public static string InsufficientMoneyExceptionMessage = "{0} can't afford {1}";
            public const decimal CostMinValue = 0m;
       
    }
}
