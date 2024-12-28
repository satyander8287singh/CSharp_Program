using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    public class AllDelegates
    {
        //public delegate void myDelegate();
        public delegate void delmethod();
        public class DelegatesClass
        {
            public void print()
            {
                Console.WriteLine("Print method of single cast delegate");
            }

            public static void show()
            {
                Console.WriteLine("Show method of single cast delegate");
            }
        }

        //public void GetSingleCastDelegate(DelegatesClass _singleDelegatesClass)
        //{
        //    DelegatesClass _singleDelegatesClass = new DelegatesClass();
        //    delmethod del1 = _singleDelegatesClass.print();
        //    delmethod del2 = DelegatesClass.show();
        //    del1();
        //    del2();
        //}
    }
}
