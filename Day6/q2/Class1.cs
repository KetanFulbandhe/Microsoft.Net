using System;

namespace ClassLib_Employee_A2
{
    public class Employee
    {
        static int getid;
        public static double TDS = 0.1;
        int _id;
        string _name;
        double _salary;
        double _netsalary;
        const int maxemp = 3;
        const int maxsal = 50000;
        static Employee()
        {
            Console.WriteLine("\tWelcome to Employee Corporation\n");
        }
        public Employee(string nm, int sal)
        {
            if (getid < maxemp)
            {
                Name = nm;
                Salary = sal;
            }
            else
            {
                Console.WriteLine("\t***Can not create object***\n");
            }
        }
        public int ID
        {
            get { return ++getid; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value > maxsal || value < 0)
                {
                    throw new Exception("Invalid Salary");
                }
                _salary = value;
            }
        }

        public double Netsalary
        {
            get { return _netsalary; }
            //set { _netsalary = value; }
        }
        //Write method who’s job is to deduct TDS 10% and return tax amount and set netsalary instance member after deducting tax.

        public double Calculate()
        {
            double tax = Salary * TDS;
            _netsalary = Salary - tax;
            //Console.WriteLine("Hii" + _netsalary + " " + tax);
            return tax;
        }
    }
}
