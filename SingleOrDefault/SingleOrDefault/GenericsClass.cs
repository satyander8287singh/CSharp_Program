using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class GenericsClass
    {
        internal class TestGenericsClass<T>
        {
            public TestGenericsClass(T data)
            {
                Console.WriteLine(data);
            }
        }

        internal class TestGenericsMethodClass
        {
            public void TestGenericMethodWithSinglePerameter<T>(T data1)
            {
                Console.WriteLine(data1);
            }

            public void TestGenericMethodWithMutltiPerameter<T>(T data1, T data2)
            {
                Console.WriteLine(data1 + " " + data2);
            }
        }

    }
}
