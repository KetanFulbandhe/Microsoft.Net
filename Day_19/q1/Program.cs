using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* * Q1. Create a table Employee having column  Id, Name, Salary. Create a class Employee having member Id, Name, Salary. Create a class BusinessLayer  and write two method
 *Public Employee search(int id)
 *Public List<Employee>(string name)
 *Above method will search the record and return results. Entry point class will display data. 
 */
namespace EmployeeSearchA1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSearch empsrc = new EmployeeSearch();

            Console.WriteLine("Search via ID");
            Employee esr = empsrc.search(1);
            Console.WriteLine("ID: {0} Name: {1} Salary: {2}", esr.Id, esr.Name, esr.Salary);
            
            Console.WriteLine("\nSearch<List> via Name");
            List<Employee> empl = empsrc.search("Todd");
            if (empl != null)
            {
                foreach (var em in empl)
                    Console.WriteLine("ID: {0} Name: {1} Salary: {2}", em.Id, em.Name, em.Salary);
            }
            else
            {
                Console.WriteLine("Data Not Found");
            }

        }
    }
}
