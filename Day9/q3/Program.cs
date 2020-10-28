using System;
/*Q3. Accept a number from user and store in object and print it*/

namespace ConsoleApp_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            string str = Console.ReadLine();
            int num;
            bool flag = int.TryParse(str, out num);

            if(flag)
            {
                object ob = num;
                Console.WriteLine("Enter number is: " + ob);

            }
            else
                Console.WriteLine("Invalid inpput");

            Console.ReadLine();
        }
    }
}
