using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class ReverseString
    {
        public void  GetReverseString() {
            string intputStr = "Hello";
            char[] charStr = intputStr.ToCharArray();
            string reverseOutPut = string.Empty;
            Console.WriteLine("Reverse string");
            for (int i = charStr.Length - 1; i>=0; i--)
            {
                reverseOutPut += charStr[i];
            }
            Console.WriteLine(reverseOutPut);  
        }  
    }
}
