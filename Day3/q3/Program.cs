using System;
//Create struct emp having member name and salary, using constructor initialized member. Write display method which will display name and salary
namespace ConsoleApp_A3
{
    struct emp
    {
        string name;
        int salary;
        public emp(String nm, int Sal)
        {
            name = nm;
            salary = Sal;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}\nSalary: {1}",name,salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            emp e1 = new emp("Todd",25000);
            e1.Display();
            Console.ReadLine();
        }
    }
}
