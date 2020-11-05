using System;
using System.Collections.Generic;
/*Q4. Accept 5 name from user and store it in an array store all name starting from “v” in to another array and print  eg input [vita, vidya, dac, edac,dbda] O/P [vita, vidya]*/

namespace NameStartV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            //HashSet<string> name = new HashSet<string>();
            
            Console.WriteLine("Enter 5 names: ");
            for (int i = 0; i < 5; i++)
                name[i] = Console.ReadLine();

            List<string> lst= new List<string>();

            for (int i = 0; i < 5; i++)
                if (name[i].StartsWith("v"))
                    lst.Add(name[i]);

            Console.WriteLine("Name start with \"v\": ");

            foreach (string str in lst)
                Console.WriteLine(str);
        }
    }
}
