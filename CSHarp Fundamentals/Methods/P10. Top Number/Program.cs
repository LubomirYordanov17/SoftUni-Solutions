using System;

namespace P10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool flag = false;
            int currNum = 0;
            int sum = 0;
            for (int i = 17; i <= number; i++)
            {
                int realNum = i;
                while (realNum > 0)
                {
                    currNum = realNum % 10;
                    sum += currNum;
                    if (currNum % 2 != 0)
                    {
                        flag = true;
                    }
                    realNum /= 10;

                }
                if (sum % 8 == 0 && flag == true)
                {
                    Console.WriteLine(i);
                }
                flag = false;
                sum = 0;
            }
        }
       


    }
}
