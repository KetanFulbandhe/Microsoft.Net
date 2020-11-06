using System;
using System.Linq;
/*
 * Q1.Create class  employee having member id, name, salary, address[put address as Vile parle, Andheri, Kandivali].
 */
namespace EmployeeExecution
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return string.Format("ID-> {0} Name-> {1} Salary-> {2} Address-> {3}",ID,Name,Salary,Address);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Employee");

            Employee[] emp = new[] {new Employee{ ID=100,Name="Tom",Salary=15000,Address="Vile parle"},
            new Employee{ID=101,Name="venny",Salary=22000,Address="Andheri"},
            new Employee{ID=102,Name="Tonny",Salary=52000,Address="Kandivali"}
            };

//a. Display all employee detail
            Console.WriteLine("All employee detail\n");
            var All = from e in emp select e;
           foreach (var em in All)
               Console.WriteLine(em);

//b. Display all employee who are staying at Andheri
            var Add = from a in emp where a.Address == "Andheri" select a;
            foreach (var ad in Add)
                Console.WriteLine(ad);

//c. Display total of all salary
            Console.WriteLine("\nDisplay total of all salary\n");
            var SumSal = (from sl in emp select sl.Salary).Sum();
            Console.WriteLine("Sum of All Salary: "+SumSal);

//d. Display  all employee who’s name start with “v”
            Console.WriteLine("\nDisplay  all employee who’s name start with \"v\"\n");
            var Vname = from vnm in emp where vnm.Name.StartsWith("v") select vnm;
            foreach (var v in Vname)
                Console.WriteLine("Name start with \"v\" -> "+v.Name);

//e. Count number of Employee in a company
            Console.WriteLine("\nCount number of Employee in a company\n");
            var ttl = (from tt in emp select tt).Count();
            Console.WriteLine("Total number of employee: " + ttl);

//f. Display all employee getting salary > 50000
            Console.WriteLine("\nDisplay all employee getting salary > 50000\n");
            var LrgSalary = from lsl in emp where lsl.Salary > 50000 select lsl;
            foreach (var LsL in LrgSalary)
                Console.WriteLine("Employee Having Salary >50000 \n "+LsL);

//g. Display min , max and average salary
            Console.WriteLine("\nDisplay min , max and average salary\n");
            var min = (from mn in emp select mn.Salary).Min();
            Console.WriteLine("Minimum Salary : " + min);

            var max = (from mx in emp select mx.Salary).Max();
            Console.WriteLine("Maximum Salary: "+max);

            var avg = (from mx in emp select mx.Salary).Average();
            Console.WriteLine("Maximum Salary: " + avg);

//h. Display all name in ascending order.
            Console.WriteLine("\nDisplay all name in ascending order\n");
            var asc = from nm in emp orderby nm.Name select nm.Name;
            foreach (var asd in asc)
                Console.WriteLine("Name in Ascending Order: "+asd);

//i. display all record salary in descending order salary wise
            Console.WriteLine("\nDisplay all record salary in descending order salary wise\n");
            var dsc = from sdnm in emp orderby sdnm.Salary descending select sdnm.Salary;
            foreach (var ds in dsc)
                Console.WriteLine("Descending order salary wise "+ds);

//h. display Id and name who’s salary is <20000
            Console.WriteLine("\nDisplay Id and name who’s salary is <20000\n");

            var grtrTwt = from sltw in emp where sltw.Salary < 20000 select sltw;
            foreach (var gts in grtrTwt)
                Console.WriteLine("Id {0} Name {1} ",gts.ID,gts.Name);
        }
    }
}