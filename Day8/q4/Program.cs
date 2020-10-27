using System;
/*Create a class swapdemo having method
 	Public void swap(int x, int y)
Job of this method is to swap two number. Create a entry point class  who’s job is to call this method and print swapped data.*/
namespace ConsoleApp_A4
{
    class swapdemo
    {
        public void swap(ref int x,ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            swapdemo sw1 = new swapdemo();
            int num1 = 5, num2 = 7;
            Console.WriteLine("Before: {0} {1}", num1, num2);
            sw1.swap(ref num1, ref num2);
            Console.WriteLine("After: {0} {1}", num1, num2);

            Console.ReadLine();
        }
    }
}
