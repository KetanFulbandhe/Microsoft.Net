using System;
// Accept two number from user and print sum of it.

namespace ConsoleApplication1_Day2A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Number: ");
            int num1, num2,sum=0;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("Addition is: "+sum);
            Console.ReadLine();
        }
    }
}
