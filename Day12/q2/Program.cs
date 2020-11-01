using System;
/*1. create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
	c.  cube of a number.
Using  Anonymous  method.

2. Solve the above code using lambda */

namespace ConsoleApp_LambdaA2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLambda.MyFactorial(5);
            MyLambda.MySquare(5);
            MyLambda.MyCube(5);
        }
    }
}
