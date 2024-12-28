using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SingleOrDefault.PrivateConstractorClass;
using static SingleOrDefault.PrivateConstractorClass.ConstractorClassA;

namespace SingleOrDefault
{
    public  class PrivateConstractorClass
    {
        public sealed class ConstractorClassA
        {
            private static ConstractorClassA instance;
            private ConstractorClassA()
            {
                Console.WriteLine("Calling private constractor of ClassA");
            }

            public static ConstractorClassA getInstance()
            {
                if (instance == null) {
                    instance = new ConstractorClassA(); 
                }
                return instance;
            }
        }

        
    }

    public class ConstractorClassB
    {
        ConstractorClassA constractorClassA = ConstractorClassA.getInstance();
    }
}
