using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class MaxValueFromArray
    {
        public void FindMaxValueFromArray() {

            int[] arrVal = new int[] { 8, 11, 7, 9 };
            int temp = arrVal[0];
            Console.WriteLine("Finding max value from array");
            for (int i = 0; i < arrVal.Length; i++)
            {
                if (arrVal[i] > temp)
                {
                    temp = arrVal[i];
                    Console.WriteLine(temp);
                }
            }
        }
    }
}
