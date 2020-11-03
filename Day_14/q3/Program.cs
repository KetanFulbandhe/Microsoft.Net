using System;
using System.Collections.Generic;
using System.IO;
/*Q4. Write a generic delegate which will point to method which will return square , cube ,and factorial of a number*/

namespace ConsoleApp_GenericDelegate
{
    public delegate void MyGenericDelegate<T>(T genD);
    
    class Program
    {
        public static void square(int s)
        {
            Console.WriteLine("Square: " + s * s);
        }
        public static void cube(int c)
        {
            Console.WriteLine("cube: " + c * c * c);
        }
        public static void factorial(int n)
        {
            int f=1;
            for(int i=1;i<=n;i++)
                f=f*i;
            Console.WriteLine("factorial: "+f);
        }
        static void Main(string[] args)
        {
            MyGenericDelegate<int> intSqGenD = new MyGenericDelegate<int>(square);
            intSqGenD(5);

            MyGenericDelegate<int> intCuGenD = new MyGenericDelegate<int>(cube);
            intCuGenD(5);

            MyGenericDelegate<int> intFactGenD = new MyGenericDelegate<int>(factorial);
            intFactGenD(5);
        }
    }
}
