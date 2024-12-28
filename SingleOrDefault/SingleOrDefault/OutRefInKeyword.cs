using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class OutRefInKeyword
    {
        public void callingOutRefInKeyword()
        {
            int outParam = 10;  // It is not compulsory to initialize a parameter or argument before it is passed to an out.
            int refParam = 20; // The parameter or argument must be initialized first before it is passed to ref.
            string inParam = "Satya@gmail.com"; // The parameter or argument must be initialized first before it is passed to in.

            Console.WriteLine("We are using Out, Ref and In keyword");

            Console.WriteLine("Before calling value of Out keyword :" + outParam);
            OutKeywordClass outKeywordClass = new OutKeywordClass();
            Console.WriteLine("After calling value of Out keyword: " + outKeywordClass.callingOutMethod(out outParam));

            Console.WriteLine("Before calling value of Ref keyword :" + refParam);
            RefKeywordClass refKeywordClass = new RefKeywordClass();
            Console.WriteLine("After calling value of Ref keyword: " + refKeywordClass.callingRefMethod(ref refParam));

            InKeywordClass inKeywordClass = new InKeywordClass();
            inKeywordClass.callingInMethod(in inParam);
        }
    }

    internal class OutKeywordClass
    {
        public int callingOutMethod(out int outParam)
        {
            // A called method is required to assign or initialize a value of a parameter (which is passed to an out) before returning to the calling method.
            return outParam = 15;
        }
    }

    internal class RefKeywordClass
    {
        public int callingRefMethod(ref int outParam)
        {
            // It is not required to assign or initialize the value of a parameter (which is passed by ref) before returning to the calling method. 
            outParam += 10;
            return outParam;
        }
    }

    internal class InKeywordClass
    {
        public void callingInMethod(in string outParam)
        {
            // We can not modify value of actual parameter.
            // We can not apply another return type instead of void.
            // Here result will be provide in Bool type.
            Console.WriteLine("Calling In keyword: " + outParam);
        }
    }
}
