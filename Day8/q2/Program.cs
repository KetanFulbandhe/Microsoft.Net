using System;
/*Q2. Create a class  having two method 
	1. 1. public int sqr(int n) :this method return square of a number
	2. public double sqr(int s): this method return cube of a number
Compile code and observed message given by compiler.*/

namespace ConsoleApp_A2
{
    class Mymeth
    {
        public int sqr(int n)
        {
            return n * n;
        }
        //public double sqr(int s)                  //ambiguos call
        public double sqr(double s)
        {
            return s * s * s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mymeth m1 = new Mymeth();
            int ansI = m1.sqr(2);
            Console.WriteLine("square int: "+ansI);

            double ansD = m1.sqr(2.4);
            Console.WriteLine("square double: "+ansD);

            Console.ReadLine();
        }
    }
}
