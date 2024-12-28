using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class MethodHidingClass
    {
        public class ClassAbc
        {
            public virtual void TestMethod()
            {
                Console.WriteLine("Parent class method runnig.");
            }
        }

        public class ChildClassXyz : ClassAbc
        {
            // Here we hiding method using new keyword.
            //public new void TestMethod()
            //{
            //    base.TestMethod();
            //    Console.WriteLine("Child class method runnig.");
            //}

            // Here we hiding method using virtual with override keyword.
            public override void TestMethod()
            {
                Console.WriteLine("Child class method runnig.");
            }
        }

    }
}
