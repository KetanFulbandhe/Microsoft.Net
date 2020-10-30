using System;
/*3. create class  Employee having member id, name, salary.
 * Id should be autoincrement.
 * Write getter setter for name and salary.
 * Write abstract method givebonus.
 * Create two child class Permanente employee and temporary employee.
 * Create array of employee class store two object of class Permanente employee and temporary employee. As soon as you call givebonus it should send message stating total salary ,bonus and name. 
*/

namespace Employee
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();

            Employee[] empArr = new Employee[4];
            empArr[0] = new PermanenteEmployee("tom", 20000);
            empArr[1] = new PermanenteEmployee("tod", 40000);
            empArr[2] = new TemporaryEmployee("John", 15000);
            empArr[3] = new TemporaryEmployee("Josh", 30000);

            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i].gbevent += m.email;
                empArr[i].gbevent += m.mobile;
            }
            foreach (Employee i in empArr)
                i.GiveBonus();
       }
    }
}
