using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class MutableVsImmutable
    {
        public void getMutableVsImmutable()
        {
            string str1 = "Satya";
            Console.WriteLine("Before chaging the value of string object: {0}", str1);    
            str1 = "Hello";
            Console.WriteLine("After chaging the value of string object: {0}", str1);

            Console.WriteLine("We are using string builder");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Ram");
            stringBuilder.Append("Laxman");
            stringBuilder.Append("Shree Ram");

            Console.WriteLine("We are printing string builder value: {0}", stringBuilder);
        }
    }
}
