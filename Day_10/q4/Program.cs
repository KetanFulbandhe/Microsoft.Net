using System;
//Q4. Create a class employee having member name and salary, it has reference of address class which display location name[eg. vile-parle] Create a duplicate object using clone method.

namespace ConsoleApp_EmployeeCloneA4
{
	class Address
    	{
        	public string LOC { get; set; }
	        public Address()
        	{
	            LOC = "vile-parle";
		}
    	}
	class Employee:ICloneable
	{
        	public string Name { get; set; }
	        public int Salary { get; set; }
	        public Address ads = new Address();

	        public Employee(string nm, int sal, string Add)
        	{
	            Name = nm;
	            Salary = sal;
	            ads.LOC = Add;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Salary, ads.LOC);
        }
        public object Clone()
        {
            Employee emp = (Employee)this.MemberwiseClone();

            Address myadd = new Address();
            myadd.LOC = this.ads.LOC;
            emp.ads = myadd;
            return emp;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("ketan",25000,"BHN");
            Employee e2 = (Employee)e1.Clone();
            

            Console.WriteLine("Before:");
            Console.WriteLine("e1 "+e1);
            Console.WriteLine("e2 "+e2);
            
            e2.Name = "tom";
            e2.Salary = 30000;
            e2.ads.LOC = "NY";

            Console.WriteLine("After: ");
            Console.WriteLine("e1 "+e1);
            Console.WriteLine("e2 "+e2);
        }
    }
}
