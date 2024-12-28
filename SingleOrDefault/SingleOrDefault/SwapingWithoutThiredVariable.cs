using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class SwapingWithoutThiredVariable
    {
        int a = 12, b = 15;
        public void GetSwapingWithoutThiredVariable()
        {
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Swaping value without thired variable a: {0} and b: {1}", a, b);
        }

    }
}
