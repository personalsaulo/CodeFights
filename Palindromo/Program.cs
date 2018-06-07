using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {





        }

        bool checkPalindrome(string inputString)
        {
            int len = inputString.Length;
            for (int i = 0; i < len; i++)
            {
                if (inputString[i] != inputString[len - 1 - i])
                    return false;

            }
            return true;
        }
        

    }
}
