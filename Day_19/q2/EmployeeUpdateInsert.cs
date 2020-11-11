using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
/*a. store employee record in database  using store procedure and strongly type insert.
*/

namespace EmployeeInsertSPUpdt
{
    public class EmployeeUpdateInsert
    {
        public SqlConnection getconnection()
        {
            SqlConnection sqlcon = new SqlConnection();
            string constring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            sqlcon.ConnectionString = constring;
            return sqlcon;
        }
        public int Adddata(Employee e)
        {
            SqlConnection sqlcon = null;
            SqlCommand sqlcmd;
            int recordAffected = 0;
            try
            {
                sqlcon = getconnection();
                sqlcmd = new SqlCommand("MyInsert", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@ename", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@esal", SqlDbType.Int).Value = e.Salary;
                sqlcon.Open();
                recordAffected = sqlcmd.ExecuteNonQuery();
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
            return recordAffected;
        }

        public int updateId(int id,string name)
        {
            SqlConnection sqlcon = null;
            SqlCommand sqlcmd;
            int no = 0;
            try
            {
                sqlcon = getconnection();
                sqlcon.Open();
                sqlcmd = new SqlCommand("update Employee set Name=@ename where Id=@eid", sqlcon);
                sqlcmd.Parameters.AddWithValue("@ename",name);

                sqlcmd.Parameters.AddWithValue("@eid", id);
                no = sqlcmd.ExecuteNonQuery();
                if (no > 0)
                {
                    Console.WriteLine("{0} rows affected", no);
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
            return no;
        }
    }
}
/*
 * CREATE PROCEDURE MyInsert
                        
       @ename     NVARCHAR(Max),       
	   @esal		int                
AS 
BEGIN 
  INSERT INTO dbo.Product  ( Name ,Salary )    VALUES (  @ename, @esal)
 End
 */