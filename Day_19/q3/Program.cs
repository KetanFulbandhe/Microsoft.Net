using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DisconnectedEmployee
{
    class Employee
    {
        public void ShowEmployee()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Employee", con);
            DataSet dataset = new DataSet();
            int n = dataAdapter.Fill(dataset);
            Console.WriteLine(n);
            Console.WriteLine(dataset.GetXml());
            Console.WriteLine(dataset.Tables[0]);
            dataset.Tables[0].TableName = "Employee";
            DataTable dt = dataset.Tables["Employee"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(row[col] + "\n name of row= " + row + "\n name of column= " + col);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ShowEmployee();
            
        }
    }
}
