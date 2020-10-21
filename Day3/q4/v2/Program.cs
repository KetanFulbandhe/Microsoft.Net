using System;
using ClassLibV1_A4;
//After  this add method cube  to a copy of class library
namespace ConsoleApp_use_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            mycaculator m1 = new mycaculator();
            int ansCu=m1.Cube(2);
            Console.WriteLine("From version 2\nCube: {0}", ansCu);
            Console.ReadLine();            
        }
    }
}
