using System;

//Q1. Declare 2 variable of a type short and store sum of it in a variable and print it.
namespace ConsoleApplication_ShortAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 5;
            short num2 = 2;
            short add = (short)(num1 + num2);
            Console.WriteLine("Addition is: "+add);
            Console.ReadLine();
        }
    }
}
