using System;
//Accept data in an array pass it to static method let this method store cube of each element , modify original array
namespace ConsoleApp_Array_A4
{
    class Program
    {
        static void modify(int[] m)
        {
            for (int j = 0; j < m.Length; j++)
                m[j] = m[j] * m[j] * m[j];
        }
        static void Main(string[] args)
        {
            int i,size;
            Console.WriteLine("Enter the size: ");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the data: ");

            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nOriginal data: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");

            }
            modify(arr);
            Console.WriteLine("\nModified data: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
