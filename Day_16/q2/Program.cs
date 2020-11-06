using System;
using System.Threading;
using System.Windows.Forms;

/*Q2. Write a method which will print 1 to 10. Create 2 thread and let both thread use this method.
Use sleep method .
*/
namespace MyThread
{
    class Program
    {
        static void PrintNumbers()
        {
            int count = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " "+count);
                count++;
                Thread.Sleep(1000);

            }
        }

        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
            t1 = new Thread(PrintNumbers);
            t2 = new Thread(PrintNumbers);
            
            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
    }
}
