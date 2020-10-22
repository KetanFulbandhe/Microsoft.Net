using System;
using ClassLibCustomer;
//Create a class customer having member Id, name, billamount. When you create a object allow to have default value. Print default value of id,name, billamount.

namespace ConsoleApp_uselib_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Console.WriteLine(c1.display());
            Console.ReadLine();
        }
    }
}
