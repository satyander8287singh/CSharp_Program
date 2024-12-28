using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal class InterviewQuestionClass
    {

        internal class stringCheckingWithCharAndLength
        {
            public void stringCheckingWithCharAndLengthMethod()
            {
                string str1 = "ram";
                string str2 = "tyu";

                char[] charArr1 = str1.ToCharArray();
                char[] charArr2 = str2.ToCharArray();
                int stringOneCounter = 0;

                for (int i = 0; i < charArr1.Length; i++)
                {

                    for (int j = 0; j < charArr2.Length; j++)
                    {
                        if (charArr1[i] == charArr2[j])
                        {
                            stringOneCounter++;
                        }
                    }
                }
                if (charArr2.Length == stringOneCounter)
                {
                    Console.WriteLine(str1 + " and " + str2 + " Both string are matching");
                }
                else
                {
                    Console.WriteLine(str1 + " and " + str2 + " Both string are not matching");
                }
            }
        }

    }
}
