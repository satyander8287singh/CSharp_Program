using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class Factorial
    {
        int n, fact = 1;
        public void GetFactorial()
        {
            n = 4;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial value : {0}", fact);
        }
    }
}
