using System;
/*Q1. Create a static class Mymeth having two static  method
	1. public int sqr(int n) :this method return square of a number
	2. public double sqr(double s): this method return square of a number
    Create a entry point class and call this method.*/

namespace ConsoleApp_A1
{
    static class Mymeth
    {
        public static int sqr(int n)
        {
            return n * n;
        }
        public static double sqr(double s)
        {
            return s * s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("square of int: "+Mymeth.sqr(5));
            Console.WriteLine("square of int: "+ Mymeth.sqr(5.2));

            Console.ReadLine();
        }
    }
}
