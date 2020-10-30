using System;
/*2. . create  a  class having instance  method to find
	a. factorial of a number
	b.  square of a number
    	c.  cube of a number.
Using delegate  call this method.
 */

namespace Delegate
{
    delegate int Mymath(int d);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mds = new MyDelegate();

            Mymath md = new Mymath(mds.factorial);
            int res = md(4);
            Console.WriteLine("Factorial "+res);

            //md = new Mymath(mds.cube);
            md = mds.square;
            res = md(3);
            Console.WriteLine("square "+res);

            //md = new Mymath(mds.factorial);
            md = mds.cube;
            res = md(5);
            Console.WriteLine("cube "+res);

        }
    }
}
