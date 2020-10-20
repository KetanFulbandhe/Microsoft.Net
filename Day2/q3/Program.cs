using System;
using ClassLib_PA_A3;
namespace ConsoleA_use_SA_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 sc = new Class1();
            int ansSq = sc.sqr(2);
            int ansCu = sc.cub(2);
            Console.WriteLine("Square: {0}\nCube: {1}",ansSq,ansCu);
            Console.ReadLine();
        }
    }
}
