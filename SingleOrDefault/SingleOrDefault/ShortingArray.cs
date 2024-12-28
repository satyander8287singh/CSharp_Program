using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class ShortingArray
    {

        public void GetShortingArray()
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }

}
