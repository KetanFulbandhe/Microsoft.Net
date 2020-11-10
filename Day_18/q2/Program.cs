using System;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
/*Q2. In the Q1  
a. store employee record in database 
b. Update and delete one record 
using ExecutenonQuery() method*/
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
                        emp.ID = Convert.ToInt32(rdr["Id"]);
                        emp.Name = rdr["Name"].ToString();
                        emp.Salary = Convert.ToInt32(rdr["Salary"]);

                        employees.Add(emp);
                    }
                    return employees;
                }
            }
        }
    }
    class Employee_InUpDel_A2
    {
        public void employeeInUpDel()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Insert Data
                    SqlCommand cmd = new SqlCommand("insert into Employee values('John',25000)", connection);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("New Input Data=" + rowsAffected + "\n");

                    //Update Data
                    cmd.CommandText = "update Employee set Salary=3200 where Id=2";
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated data=" + rowsAffected + "\n");

                    //Deletion Data
                    cmd.CommandText = "Delete from Employee where Id=1002";
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Number of record deleted=" + rowsAffected);
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.StackTrace);

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
                Console.WriteLine("{0} {1} {2}", e.ID, e.Name, e.Salary);

            Employee_InUpDel_A2 IUD = new Employee_InUpDel_A2();
            IUD.employeeInUpDel();
            

        }
    }
}
