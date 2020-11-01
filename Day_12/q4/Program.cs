using System;

/*4. Create class  Employee having member id, name, salary write ToString() method..
Create 100000 object of employee class. Call Collect method to for force GC. Also print generation of object.
*/

namespace ConsoleApp_ForceGarbageCollectionA4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                Employee emp = new Employee("Todd", 10000);
            }
            GC.Collect();

            Console.WriteLine("count swept of Generation 0: "+GC.CollectionCount(0));

            Console.WriteLine("count swept of Generation 1: "+GC.CollectionCount(1));

            Console.WriteLine("count swept of Generation 2: "+GC.CollectionCount(2));

            Console.ReadLine();
        }
    }
}
