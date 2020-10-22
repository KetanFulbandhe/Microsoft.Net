using System;

namespace ClassLib_Employee
{
    public class Employee
    {
        int Id;
        string Name;
        int Salary;
        double NetSalary;
        static Employee()
        {
            Console.WriteLine("\tMyEmployee Corporation\n");
        }
        public Employee(int id, string nm, int sal)
        {
            this.Id = id;
            this.Name = nm;
            this.Salary = sal;
        }
        public double Calculate()
        {
            NetSalary = Salary - Salary * 0.1;
            return NetSalary;
        }
        public string Display()
        {
            double nsal = Calculate();
            return string.Format("Name: {0} Netsalary: {1}", Name, nsal);
        }

    }
}
