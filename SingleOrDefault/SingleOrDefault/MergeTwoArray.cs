using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class MergeTwoArray
    {
        public void MergingTwoArray()
        {

            int[] arr1 = new int[] { 1, 4, 3, 6 };
            int[] arr2 = new int[] { 8, 2, 7, 9 };
            int[] result = new int[arr1.Length + arr2.Length];
            Console.WriteLine("Merging two array");
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                result[arr1.Length + j] = arr2[j];
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
