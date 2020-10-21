using System;
using ClassLibV1_A4;
namespace ConsoleApp_use_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 refObj = new Class1();
            int ansAdd=refObj.add(5, 2);
            int ansProd = refObj.Prod(5, 2);
            Console.WriteLine("From version 1\nAddition: {0}\nProduct: {1}", ansAdd, ansProd);
            Console.ReadLine();
        }
    }
}
