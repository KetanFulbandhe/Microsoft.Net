using System;

//Q4. Accept a string from user and convert it to lowercase and check reference of both string
namespace ConsoleApp_String_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str1=Console.ReadLine();
            string str2 = str1.ToLower();
            Console.WriteLine("{0} {1} {2}",str1,str2,Object.ReferenceEquals(str1,str2));

            Console.ReadLine();
        }
    }
}
