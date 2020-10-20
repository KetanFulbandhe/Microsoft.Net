using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_ProductType
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 5;
            byte num2 = 2;
            byte prodt;
            prodt = (byte)(num1 * num2);
            Console.WriteLine("Product is :" + prodt);
            Console.ReadLine();
        }
    }
}
