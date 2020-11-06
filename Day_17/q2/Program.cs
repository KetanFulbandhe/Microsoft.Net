using System;
using System.Data.SqlClient;

namespace EmployeeConSetter
{
    class Employee
    {
        public void EmployeeDetails()
        {
            string connectionString = @"Data Source=(localdb)\Projects;Initial Catalog=Demodata;Integrated Security=True";

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionString;
                SqlCommand cmd = new SqlCommand("Select * from Employee",con);
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
            emp.EmployeeDetails();
        }
    }
}
