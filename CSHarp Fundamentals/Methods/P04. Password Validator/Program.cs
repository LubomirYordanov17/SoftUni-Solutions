using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passminNum = 6;
            const int passmaxNum = 10;
            const int passMinCount = 2;
            string password=Console.ReadLine();
            bool isValid = ValidatePassword(password, passminNum,passmaxNum,passMinCount);
            if (isValid==true)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassword(string password,int passminNum,int passmaxNum,int passMinCount)
        {
            bool isValid = true;
            if (!ValidateLength(password,passminNum,passmaxNum))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid= false;
            }
            if (!ValidateIfTruePass(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid= false;
            }
            if (!ValidateMinNum(password,passMinCount))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            return isValid;
        }
        static bool ValidateIfTruePass(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
               
            }
            return true;
        }
        static bool ValidateLength(string password,int minNum,int maxNum)
        {
            if (password.Length>=minNum&&password.Length<=maxNum)
            {
                return true;
            }
            return false;
        }
        static bool ValidateMinNum(string password, int minCount)
        {
            int digits=0;
            foreach  (char ch in password  )
            {
                if (Char.IsDigit(ch))
                {
                    digits++;

                }
                

            }
            return digits>=minCount;
        }
        
    }
}
