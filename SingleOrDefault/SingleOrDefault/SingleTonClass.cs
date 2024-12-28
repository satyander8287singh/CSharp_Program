using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    internal sealed class SingleTonClass
    {
        private static SingleTonClass instance = null;
        private static object obj;
        private SingleTonClass() { }

        public static SingleTonClass GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new SingleTonClass();
                    }
                }
            }

            return instance;
        }
    }
}
