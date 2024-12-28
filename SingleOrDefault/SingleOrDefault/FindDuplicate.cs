using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class FindDuplicate
    {
        public void GetDuplicate() {
            string[] inputstr = new string[] { "A", "B", "C", "B", "C" };
            HashSet<string> distinct = new HashSet<string>();
            HashSet<string> duplicate = new HashSet<string>();
            string[] duplicateVal = { };
            foreach (string str in inputstr)
            {
                if (!distinct.Add(str))
                {
                    duplicate.Add(str);
                }
            }

            duplicateVal = duplicate.ToArray();
            Console.WriteLine("Find Duplicate value from array");
            foreach (string str in duplicateVal)
            {
                Console.WriteLine(str);
            }
        }  
        
    }
   
}
