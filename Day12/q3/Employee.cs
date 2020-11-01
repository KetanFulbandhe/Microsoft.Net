using System;
/*3. create class  Employee having member id, name, salary write ToString() method..
Create a object of employee class and store it in var ,Object and dynamic variable.
Call tostring method to display data.*/

namespace ConsoleApp_VarDynamicObjectA3
{
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
            Console.WriteLine("id: {0} name: {1} salary: {2}",id,name,salary);
            return null;
        }
    }
}
