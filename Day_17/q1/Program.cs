using System;
using System.Data.SqlClient;
/*Q1. Create table Emp having column Id, Name, Salary.using ADO.Net display all detail of the table.
Do not forget to add record in table.*/
namespace EmployeeADO
{
    class Employee
    {
        public void EmployeeDetail()
        {
            string connectionString = @"Data Source=(localdb)\Projects;Initial Catalog=Demodata;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                con.Open();
                Console.WriteLine("Connected!!!");
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Salary"]);

                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeDetail();
        }
    }
}
