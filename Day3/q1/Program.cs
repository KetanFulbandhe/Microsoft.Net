using System;

namespace ConsoleApplicationStructProg
{
    struct Math
    {
        public static int Square(int s)
        {
            return (s*s);
        }
        public static int Cube(int c)
        {
            return (c*c*c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ansSq = Math.Square(2);
            int ansCu = Math.Cube(2);
            Console.WriteLine("Square: {0}\nCube: {1}", ansSq, ansCu);
            Console.ReadLine();
        }
    }
}
