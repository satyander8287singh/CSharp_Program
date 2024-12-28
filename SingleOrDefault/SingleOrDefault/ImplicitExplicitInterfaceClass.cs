using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class ImplicitExplicitInterfaceClass
    {

        internal class ImplicitInterfaceClass : ITest
        {
            public void TestMethod()
            {
                Console.WriteLine("Implicit interface method calling");
            }
        }

        internal class ExplicitInterfaceClass : ITest
        {
            void ITest.TestMethod()
            {
                Console.WriteLine("Explicit interface method calling");
            }
        }
    }

    interface ITest {
        void TestMethod();
    }
}
