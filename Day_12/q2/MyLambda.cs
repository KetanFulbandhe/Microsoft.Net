using System;
/*1. create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
	c.  cube of a number.
Using  Anonymous  method.

2. Solve the above code using lambda */

namespace ConsoleApp_LambdaA2
{
    public delegate void LambdaMtd(int no);

    public static class MyLambda
    {
        static LambdaMtd objL;

        public static void MyFactorial(int n)
        {
            //LambdaMtd obj = no =>
            objL = no =>
            {
                int f = 1;
            
                for (int i = 1; i <= no; i++)
                    f = f * i;
                Console.WriteLine("Factorial : "+f);
            };
            //obj(n);
            objL(n);
        }
        public static void MySquare(int n)
        {
            //LambdaMtd obj = no =>
            objL = no =>
            {
                Console.WriteLine("Square : " + no * no);
            };
            objL(n);
        }
        public static void MyCube(int n)
        {
            //LambdaMtd obj = no =>
            objL = no =>
            {
                Console.WriteLine("Cube: "+no * no *no);
            };
            objL(5);
        }
    }
}
