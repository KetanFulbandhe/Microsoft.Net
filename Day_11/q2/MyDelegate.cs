using System;
/*a. factorial of a number
	b.  square of a number
    c.  cube of a number.
 */

namespace Delegate
{
    public class MyDelegate
    {
        public int factorial(int n)
        {
            int i,f=1;

            for (i = 1; i <= n; i++)
                f = f * i;

            return f;
        }
        public int square(int s)
        {
            return s * s;
        }
        public int cube(int c)
        {
            return c * c * c;
        }
    }
}
