using System;
//Accept data in 3*3matrix and print row wise sum
namespace ConsoleApp_Array_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c,rsum = 0;
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter Data: ");
            for (r = 0; r < 3; ++r)
            {
                for (c = 0; c < 3; ++c)
                {
                    matrix[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Martix: ");
            for (r = 0; r < 3; ++r)
            {
                for (c = 0; c < 3; ++c)
                {
                    Console.Write(matrix[r, c]+" ");
                    rsum = rsum + matrix[r, c];
                }
                Console.WriteLine("row sum: "+rsum);
                rsum = 0;
            }

                Console.ReadLine();
        }
    }
}
