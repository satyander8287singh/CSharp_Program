using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class RemovingDeuplicacy
    {
        public void RemovingDeuplicacyfromArray()
        {
            string[] inputVal = new string[] { "Amit", "Satya", "Sunil", "Akash", "Satya", "Amit" };
            int inputLength = inputVal.Length;
            string[] unique_Val = new string[inputLength];
            int uniqueInputCount = 0;
            Console.WriteLine("Removing duplicacy from array");
            for (int i = 0; i < inputLength; i++)
            {
                bool duplicateVal = false;
                for (int j = 0; j < inputLength; j++)
                {
                    if (inputVal[i] == unique_Val[j])
                    {
                        duplicateVal = true;    
                    }
                }

                if (!duplicateVal)
                {
                    unique_Val[uniqueInputCount] = inputVal[i];
                    uniqueInputCount++;
                }
            }
            foreach (var item in unique_Val)
            {
                Console.WriteLine(item);
            }
        }
    }
}
