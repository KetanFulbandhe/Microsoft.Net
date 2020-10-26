using System;
//Q1. Accept 5 element in an array and sort descending order
namespace ConsoleApp_ArraySort_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter element: ");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int no in arr)
                Console.Write(no + " ");

            Console.ReadLine();
        }
    }
}
