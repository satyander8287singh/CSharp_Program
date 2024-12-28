using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            int n = 5;
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even");
            }
            else
            {
                Console.WriteLine(n + " is Odd");
            }
        }
    }
}
