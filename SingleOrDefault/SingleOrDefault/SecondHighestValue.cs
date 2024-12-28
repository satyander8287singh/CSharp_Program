using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class SecondHighestValue
    {
        public void SecondHihestValuefromArray()
        {
            int[] inputVal = new int[] { 6, 8, 2, 4, 9 };
            int maxVal = 0;
            int secondMaxVal = 0;

            foreach (var val in inputVal)
            {
                if (val > maxVal)
                {
                    secondMaxVal = maxVal;
                    maxVal = val;
                }
                else if (val > secondMaxVal && val < maxVal)
                {
                    secondMaxVal = val;
                }
            }

            Console.WriteLine("Second highest value from array: " + secondMaxVal);

        }

    }
}
