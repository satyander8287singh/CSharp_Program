using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class CharacterCount
    {
        public void GetCharacterCountfromString()
        {

            string inputStr = "Im a best developer";
            inputStr = inputStr.Replace(" ", string.Empty);
            Console.WriteLine("Character Count from String");
            while (inputStr.Length > 0)
            {
                int count = 0;
                Console.Write(inputStr[0] + ":");
                for (int i = 0; i < inputStr.Length; i++)
                {
                    if (inputStr[0] == inputStr[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);

                inputStr = inputStr.Replace(inputStr[0].ToString(), string.Empty);
            }
        }

    }
}
