using System;
using ClassLib_PA_A2;
namespace ConsoleA_use_PA_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareCube sc = new SquareCube();
            int ansSq = sc.sqr(2);
            int ansCu = sc.cub(2);
            Console.WriteLine("Square: {0}\nCube: {1}", ansSq, ansCu);
            Console.ReadLine();
        }
    }
}
