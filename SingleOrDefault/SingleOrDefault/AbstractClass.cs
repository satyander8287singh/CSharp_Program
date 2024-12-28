using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleOrDefault
{
    public abstract class AbstractClass
    {
        /// <summary>
        /// We can create constractor in abstract class but can not apply private acces modifiers
        /// We can create static constractor and static variables in abstract class
        /// </summary>
        static AbstractClass() { }
        static int a = 0;
        /// <summary>
        /// Not maindatory abstract method in abstract class;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public abstract int Sum(int x, int y);
        public abstract int Multi(int x, int y);
        public int Sub(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        ///  We can use static fun in abstract class but we
        ///  can access in this fun with class in other class
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Div(int x, int y)
        {
            return x / y;
        }
    }

    public abstract class Example2 : AbstractClass
    {
        public override int Multi(int x, int y)
        {
            return x * y;
        }

    }

    public class MyClass : Example2
    {
        public static int a;
        public readonly int b;
        public MyClass()
        {
            a = 1;
            a = 2;
            b = 3;
            b = 4;
        }
        
        public override int Sum(int x, int y)
        {
            return x + y;
        }
    }

  }
