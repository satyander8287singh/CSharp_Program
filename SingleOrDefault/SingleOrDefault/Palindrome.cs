using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class Palindrome
    {
        int sum = 0, r, n = 121, temp;
        public void CheckPalindrome()
        {
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.Write("Number is Palindrome.");
            }
            else
            {
                Console.Write("Number is not Palindrome");
            }
        }

    }
}
