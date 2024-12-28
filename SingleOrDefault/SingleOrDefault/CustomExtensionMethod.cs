using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class CustomExtensionMethod
    {
        public void ExtensionMethod()
        {
            string inputVal = "Satya";
            Console.WriteLine(inputVal.GetOutput());    
        }
    }

    internal static class ExtensionMethodClass
    {
        public static string GetOutput(this string val)
        {
            List<string> listVal = new List<string>();
            listVal.Add("Sunil");
            listVal.Add("Satya");
            listVal.Add("Pawan");
            listVal.Add("Manoj");

            var data = listVal.Where(x => x == val).SingleOrDefault();
            return data;
        }

    }

   
}
