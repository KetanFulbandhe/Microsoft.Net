using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
/*Create a class BusinessLayer  and write two method
 *Public Employee search(int id)
 *Public List<Employee>(string name)
 *Above method will search the record and return results. */
namespace EmployeeSearchA1
{
    public class EmployeeSearch
    {
        public SqlConnection getconnection()
        {
            SqlConnection sqlcon = new SqlConnection();
            string connstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            sqlcon.ConnectionString = connstring;
            return sqlcon;
        }
        public Employee search(int id)
        {
            SqlConnection sqlcon = null;
            SqlCommand sqlcmd;
            Employee e = null;
            try
            {
                sqlcon = getconnection();
                sqlcon.Open();
                sqlcmd = new SqlCommand("select * from Employee where id=@eid", sqlcon);
                sqlcmd.Parameters.AddWithValue("@eid", id);
                SqlDataReader rd = sqlcmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToInt32(rd["Salary"]);
                        break;
                    }
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                sqlcon.Close();
                sqlcon = null;
            }
            return e;
        }
        public List<Employee> search(string name)
        {
            SqlConnection sqlcon = null;
            SqlCommand sqlcmd;
            List<Employee> el = null;
            try
            {
                sqlcon = getconnection();
                sqlcon.Open();
                sqlcmd = new SqlCommand("select * from Employee where name=@eid", sqlcon);
                sqlcmd.Parameters.AddWithValue("@eid", name);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                   el = new List<Employee>();
                   while (rd.Read())
                   {
                       Employee e = new Employee();
                       e.Id = Convert.ToInt32(rd["Id"]);
                       e.Name = rd["Name"].ToString();
                       e.Salary = Convert.ToInt32(rd["Salary"]);
                       el.Add(e);
                   }
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                sqlcon.Close();
                sqlcon = null;
            }
            return el;
        }
    }
}
