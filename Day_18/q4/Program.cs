using System;
using System.Data.SqlClient;
using System.Configuration;
/*Q4. Create a table product having column Id, Name ,Qty, price. Using like query display all product starting from letter ‘t’. try SQL Injection.*/
namespace ProductLikeSQLinjec
{
    class ProductInjectionParameterize
    {
        public void ProductDetails(string pname)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(ConnectionString))
    {
        try
        {
            SqlCommand cmd = new SqlCommand("select * from Product where Name like'" + pname + "%'", connection);
            connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"], rd["Qty"]);
            }
        }
        catch(Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
    }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProductInjectionParameterize pInj = new ProductInjectionParameterize();
            string str = "t";
            pInj.ProductDetails(str);
            
        }
    }
}