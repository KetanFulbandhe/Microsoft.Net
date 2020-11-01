using System;
/*3. create class  Employee having member id, name, salary write ToString() method..
Create a object of employee class and store it in var ,Object and dynamic variable.
Call tostring method to display data.*/

namespace ConsoleApp_VarDynamicObjectA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Tom", 25000);
            emp.ToString();

            var v = emp;
            v.ToString();
            //emp="Todd";      // compilation error refType=valueType Not allowed

            Object o = emp;
            o.ToString();
            o = 1000;           //Allowed

            dynamic dny = emp;
            dny.ToString();
            dny = 1000;         //Allowed dynamic check at runtime
        }
    }
}
