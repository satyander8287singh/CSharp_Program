using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class DuplicateCharCount
    {
        public void GetDuplicateCharCount() {
            string str1 = "ABBDDDTTTTTSSSS";
            int Char_count = 0;
            string duplicateChar = "";
            char[] inputStr1 = str1.ToCharArray();
            HashSet<string> distnict = new HashSet<string>();
            HashSet<string> duplicate1 = new HashSet<string>();
            string[] final_Final = { };

            foreach (var str in inputStr1)
            {
                if (!distnict.Add(str.ToString()))
                {
                    duplicate1.Add(str.ToString());
                }
            }

            final_Final = duplicate1.ToArray();
            Console.WriteLine("Find Duplicate character count from array");
            for (int i = 0; i < final_Final.Length; i++)
            {
                duplicateChar = final_Final[i];
                for (int k = 0; k < inputStr1.Length; k++)
                {
                    if (final_Final[i] == inputStr1[k].ToString())
                    {
                        Char_count++;
                    }
                }
               
                Console.WriteLine(duplicateChar + "-" + Char_count);
                Char_count = 0;
            }
        } 
    }
}
