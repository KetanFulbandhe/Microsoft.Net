using System;
using System.Collections.Generic;
/*Q2. Accept 5 element in an array having duplicate value print unique array.*/


namespace UniqueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 elements: ");

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
                hs.Add(arr[i]);

            Console.WriteLine("UniqueArray");
            foreach (var h in hs)
                Console.WriteLine(h);
        }
    }
}
