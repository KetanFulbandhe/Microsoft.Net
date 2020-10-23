using System;
using ClassLib_Employee_A1;
//Create a class Employee having member variable Firstname, Lastname, Middlename.let your application create object even if user does not enter Middlename. Create two constructor one take parameter for Firstname, Lastname and second constructor which will take all the parameter. Write display method which will display detail of the object.

namespace ConsoleAppEmployeeA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("sachin", "tendulkar");
            Console.WriteLine(e1.Display());
            Employee e2 = new Employee("sachin", "ramesh", "tendulkar");
            Console.WriteLine(e2.Display());

            Console.ReadLine();
        }
    }
}
