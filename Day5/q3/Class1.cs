using System;

namespace ClassLib_employee_A3
{
    public class Employee
    {
        static int getid;
        public static double TDS=0.1;
        int Id;
        string Name;
        double Salary;
        double netsalary;
        const int maxemp=3;
        const int maxsal = 50000;
        static Employee()
        {
            Console.WriteLine("\tWelcome to Employee Corporation\n");
        }
        public Employee(string nm, int sal)
        {
            if (getid < maxemp)
            {
                if (sal > maxsal)
                {
                    Console.WriteLine("Invalid Salary");
                }
                else {
                    Id = ++getid;
                    Name = nm;
                    Salary = sal;
                }
            }
            else
            {
                Console.WriteLine("\t***Can not create object***\n");
            }
        }
        public double Calculate_netsalary()
        {
           // TDS = 0.1;
            netsalary = Salary - Salary * TDS;
            return netsalary;
        }
        public string Display()
        {
            double nsal = Calculate_netsalary();
            return string.Format("Name: {0} Netsalary: {1}", Name, nsal);
        }
    }
}
