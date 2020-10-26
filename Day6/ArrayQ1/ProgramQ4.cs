using System;
//Accept data in an array and print average.
namespace ConsoleApp_Array_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size,sum=0,avg;
            Console.WriteLine("Enter size of array: ");
            size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Array data: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum =sum + arr[i];
            }
            avg = sum / size;
            Console.WriteLine("Average of Array is : "+avg);


            Console.ReadLine();
        }
    }
}
