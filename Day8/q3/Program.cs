using System;
/*Q3. Create  class  outdemo having method 
1.public int[] sqrarray(int[] arr, out int sum)
Job of this method is to do the sum of all element of an array. This method should store square of each elements in to new array. Method should return new array.*/

namespace ConsoleApp_uselib_A3
{
    class outdemo
    {
        static void square(int[] c)
        {
            for (int i = 0; i < 5; i++)
            {
                c[i] = c[i] * c[i];
            }
        }
        public int[] sqrarray(int[] arr, out int sum)
        {
            sum = 0;
            int[] sqarr = new int[5];

            for (int j = 0; j < 5; j++)
                sum = sum + arr[j];

            square(arr);

            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] myarr ={2,4,5,7,9};

            outdemo ot1 = new outdemo();
            int sum;
            ot1.sqrarray(myarr, out sum);

            Console.WriteLine("Sum is : "+ sum);
            Console.WriteLine("Square of array element: ");
            for (int k = 0; k < 5; k++)
            {
                Console.Write(myarr[k]+" ");
            }
                Console.ReadLine();
        }
    }
}
