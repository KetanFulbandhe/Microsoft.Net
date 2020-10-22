using System;
using ClassLib_Employee;
//Create a class Employee having private instance member Id, Name Salary, netsalary. Create method calculate_netsalary who’s job is to deduct 10% of TDS.. Write method display which will display name and netsalary. This application will be classlibrary.
//Create console application and use this class library. Create at least two object of Employee class 
namespace ConsoleApp_uselib_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(10,"Tom",20000);
            Console.WriteLine(e1.Display());

            Employee e2 = new Employee(11, "Todd", 50000);
            Console.WriteLine(e2.Display());

            Console.ReadLine();
        }
    }
}
