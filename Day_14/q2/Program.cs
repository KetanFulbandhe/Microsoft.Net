using System;
using System.Collections.Generic;
/*Q2. Write a static class with generic method swap, which should able to swap 2 value of any type and it should also swap two employee object. 
*/

namespace ConsoleAppl_GenericSwap
{
    public static class GenericSwap
    {
        public static void MyGenSwap<T>(ref T a, ref T b)
        {
           // Console.WriteLine("typeof data: {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
    public class Employee
    {
        static int getid;
        int id;
        string name;
        int salary;
        public Employee(string nm, int sal)
        {
            id = ++getid;
            name = nm;
            salary = sal;
        }
        public override string ToString()
        {
            Console.WriteLine("id: {0} name: {1} salary: {2}", id, name, salary);
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before: {0} {1}", a, b);
            
            GenericSwap.MyGenSwap<int>(ref a, ref b);
            Console.WriteLine("After: {0} {1}", a, b);

            Console.WriteLine("\n\n");
            Console.WriteLine("Before: ");
            Employee emp1 = new Employee("Tom", 25000);
            Employee emp2 = new Employee("Todd", 30000);
            Console.WriteLine("{0} {1}", emp1.ToString(), emp2.ToString());
            Console.WriteLine("After:");
            GenericSwap.MyGenSwap<Employee>(ref emp1, ref emp2);
            Console.WriteLine("{0} {1}", emp1.ToString(), emp2.ToString());
        }
    }
}
