using System;
//Q3. Create array of anonymous object displaying name and salary. Print all detail

namespace ConsoleApp_AnonymousA3
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyanonArray = new[] { 
                                    new { name = "Akshay", salary = "50000" }, 
                                    new { name = "Shriraj", salary = "40000" },
                                    new { name = "Ketan", salary = "450000" },
                                    };
            foreach(var a in MyanonArray)
                Console.WriteLine(a.name+" "+a.salary);
        }
    }
}
