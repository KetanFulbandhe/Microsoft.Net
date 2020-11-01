using System;
/*4. Create class  Employee having member id, name, salary write ToString() method..
Create 100000 object of employee class. Call Collect method to for force GC. Also print generation of object.
*/

namespace ConsoleApp_ForceGarbageCollectionA4
{
    public class Employee
    {
        static int getid;
        int id;
        string name;
        int salary;

        public Employee(string nm,int sal)
        {
            id = ++getid;
            name = nm;
            salary = sal;
        }
        public override string ToString()
        {
            return string.Format("Id {0} name {1} string {2}",id,name,salary);
        }
    }
    

}
