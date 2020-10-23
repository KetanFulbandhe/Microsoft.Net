using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib_Employee_A1
{
    public class Employee
    {
        string Firstname, Lastname, Middlename;
        static Employee()
        {
            Console.WriteLine("\tWelcome to Employee Corporation\n");
        }
        public Employee(string Fnm, string Lnm)
        {
            this.Firstname = Fnm;
            this.Lastname = Lnm;
        }
        public Employee(string Fnm, string Mnm, string Lnm)
        {
            this.Firstname = Fnm;
            this.Middlename = Mnm;
            this.Lastname = Lnm;
        }
        public string Display()
        {
            return Firstname + " " + Middlename + " " + Lastname;
        }
    }
}
