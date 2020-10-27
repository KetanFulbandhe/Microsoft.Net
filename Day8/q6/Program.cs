using System;
/*Create a class mymath having method sum who’s job is to find average. This method should work even if it’s called with different number of arguments eg. sum(4,5) ,sum(4,7,8,9)*/

namespace ConsoleApp_A6
{
    class mymath
    {
        public float sum(params int[] arr)
        {
            int total = 0, len = arr.Length;
                       
            for (int i = 0; i < len; i++)
                 total = total + arr[i];

            float avg =(total) / len;
            return avg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mymath m1 =new mymath();
            float res;
            res = m1.sum(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine("Average is: "+res);

            res = m1.sum(1, 2, 3);
            Console.WriteLine("Average is: " + res);

            res = m1.sum(5, 2);
            Console.WriteLine("Average is: " + res);

            Console.ReadLine();
        }
    }
}
