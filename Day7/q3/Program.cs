using System;
//Q3. Accept 5 element in an array and copy it to another array.
namespace ConsoleApp_ArraySort_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] myarr = new int[5];
            Console.WriteLine("Enter element: ");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            arr.CopyTo(myarr,0);
            Console.WriteLine("Copied array : ");
            foreach (int no in myarr)
                Console.Write(no + " ");

            Console.ReadLine();
        }
    }
}
