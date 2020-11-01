using System;
/*1. create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
	c.  cube of a number.
Using  Anonymous  method.*/

namespace ConsoleApp_AnonymousMethodA1
{
    public delegate void AnonymousMtd(int no);

    public static class MyAnonmous
    {
        static AnonymousMtd obj;

        public static void MyFact(int n)
        {
            obj = delegate(int no)
            { 
            int f = 1;
            
            for (int i = 1; i <= no; i++)
                f = f * i;
            Console.WriteLine("Factorial : "+f);
            };
            obj(n);
        }
        public static void MySquare(int n)
        {
            obj = delegate(int no)
            {
                Console.WriteLine("Square: "+ (no * no));
            };
            obj(n);
        }
        public static void MyCube(int n)
        {
            obj = delegate(int no)
            {
                Console.WriteLine("Cube : "+(no * no * no));
            };
            obj(n);
        }
    }
}
