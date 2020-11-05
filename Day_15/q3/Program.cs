using System;
using System.Collections.Generic;
/*Q3. Accept 5 element in an array and store all even number in another array and print. Use lambda */

namespace EvenLambda
{
    delegate bool IsOdd(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 elements: ");

            
            int[] arr=new int[5];
            List<int> lst = new List<int>();

            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            IsOdd isodd = n => n % 2 == 0;

            for (int i = 0; i < arr.Length; i++)
                if (isodd(arr[i]))
                    lst.Add(arr[i]);

            Console.WriteLine("even");

            foreach (var n in lst)
                Console.WriteLine(n);
        }
    }
}
