using System;
//Accept data in an array and print sum  also store square of each element in new array.
namespace ConsoleApp_Array_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, sum = 0,len;
            Console.WriteLine("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[] sqArr = new int[size];
            len = arr.Length;
            Console.WriteLine("Enter Array Data: ");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
                sqArr[i] = arr[i] * arr[i];
            }
            Console.WriteLine("\nArray sum: " + sum);

            foreach(int i in sqArr)
                Console.Write(i+" ");

            Console.ReadLine();
        }
    }
}
