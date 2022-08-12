using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool balanced = false;
            char ch = expression[0];
           
            foreach (char item in expression)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    parentheses.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    if (parentheses.Count!=0)
                    {


                        string brackets = parentheses.Peek().ToString() + item;

                        if ((brackets != "[]") && (brackets != "{}") && (brackets != "()"))
                        {
                            balanced = false;
                            break;
                        }
                        else
                        {
                            balanced = true;
                            parentheses.Pop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
