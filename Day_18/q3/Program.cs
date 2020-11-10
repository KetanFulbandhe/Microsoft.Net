using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
/*Q3. Use aggregate function ie. Print max salary and count number of employee in database*/
namespace EmployeeMaxSalary_A3
{
    class Employee
    {
        public int CountMaxSalary
        {
            get
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                int Ecount = 0;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select Count(Id) from Employee", connection);
                        connection.Open();
                        Ecount = (int)cmd.ExecuteScalar();
                        connection.Close();
                        cmd.CommandText = "select max(Salary) from Employee";
                        cmd.Connection = connection;
                        connection.Open();
                        object sal = cmd.ExecuteScalar();
                        Console.WriteLine("Maximum Salary : "+sal);
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                    }
                    return Ecount;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            int res = emp.CountMaxSalary;
            Console.WriteLine("Number of Employee in DB= "+ res);

        }
    }
}      