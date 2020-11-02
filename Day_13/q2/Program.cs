using System;
using System.IO;

namespace ConsoleApp_StudentA2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            student s1 = new student("John", 40);
            student s2 = new student("Jerry", 38);

            Console.WriteLine("Before: ");
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            
            
            try
            {                
                s1.give_gracemarks(4);
                //s1.give_gracemarks(6);         //cause Exception
                s2.give_gracemarks(3);
                
            }
            catch (MyException e)
            {
                Console.WriteLine("Exception occour: " + e.emsg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("After: ");
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            using (var fileStream = new FileStream("Out.txt", FileMode.Append))
            {
                StreamWriter fstrOut = new StreamWriter(fileStream);
                string str = s1.ToString();
                str += "\n";
                str += s2.ToString();
                fstrOut.Write(str);
                fstrOut.Close();
            } 
        }
     }
}
