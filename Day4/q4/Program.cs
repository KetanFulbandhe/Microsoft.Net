using System;
using ClassLib_Printer;
//Create a class Printer with a private constructor. Your application should give only one reference of the printer object.
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = Printer.Instance();
            Printer p2 = Printer.Instance();
            if (p1 == p2)
                Console.WriteLine("Objects are poniting to same instance");

            Console.ReadLine();
        }
    }
}
