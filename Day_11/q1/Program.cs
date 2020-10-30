using System;
/*1. create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
    c.  cube of a number.*/
namespace StaticDelegate
{
    delegate int Mymath(int d);
    //RecursiveMethod CallMethod = null;
    //        CallMethod = delegate(int value)
    //        {
    //            return value * (value == 1 ? 1 : CallMethod(value - 1));
    //        };

    static class MyDelegate
    {
        static public int factorial(int n)
        {
            int i, f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static public int square(int s)
        {
            return s * s;
        }
        static public int cube(int c)
        {
            return c * c * c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mymath md = new Mymath(MyDelegate.factorial);
            int res = md(4);
            Console.WriteLine("factorial "+res);
            
            md = new Mymath(MyDelegate.square);
            res = md(3);
            Console.WriteLine("square "+res);

            md = new Mymath(MyDelegate.cube);
            res = md(5);
            Console.WriteLine("cube "+res);
        }
    }
}
