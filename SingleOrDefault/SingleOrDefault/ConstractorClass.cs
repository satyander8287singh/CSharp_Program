using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    partial class ConstractorClass
    {
        public ConstractorClass() {
            Console.WriteLine("Class ABC default constractor runing");
        }
        static ConstractorClass()
        {
            Console.WriteLine("Class ABC static constractor runing");
        }

    }

    partial class ClassQWE : ConstractorClass
    {
        public ClassQWE()
        {
            Console.WriteLine("Class QWE default constractor runing");
        }
        static ClassQWE()
        {
            Console.WriteLine("Class QWE static constractor runing");
        }
    }

    partial class ClassXYZ : ClassQWE
    {
        public ClassXYZ()
        {
            Console.WriteLine("Class XYZ default constractor runing");
        }
        static ClassXYZ()
        {
            Console.WriteLine("Class XYZ static constractor runing");
        }

        public void Demo1()
        {
            Console.WriteLine("Class XYZ non-static method runing");
        }
        public static void Demo2()
        {
            Console.WriteLine("Class XYZ static method runing");
        }

    }
}
