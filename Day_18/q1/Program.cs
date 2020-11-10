using System;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
/*Q1. Create a table Employee having column  Id, Name, Salary. Create a class Employee having member Id, Name, Salary. Create a class BusinessLayer with a getter method who’s job is to return list of the employee retrieved from database and map to the class Employee.*/
namespace Employee
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class BusinessLayer
    {
        public List<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                
                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Employee", con);
                    con.Open();
                    Console.WriteLine("Connected!!!");
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.ID=Convert.ToInt32(rdr["Id"]);
                        emp.Name=rdr["Name"].ToString();
                        emp.Salary=Convert.ToInt32(rdr["Salary"]);

                        employees.Add(emp);
                    }
                    return employees;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer b1 = new BusinessLayer();
            foreach (Employee e in b1.Employees)
                Console.WriteLine("{0} {1} {2}",e.ID,e.Name,e.Salary);
            //App.config baki ahe
        }
    }
}
