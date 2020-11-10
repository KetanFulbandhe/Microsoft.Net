using System;
using System.Data.SqlClient;
using System.Configuration;
namespace ProductLikeParameterizeQry
{
    class ProductParameterizeQuery
    {
        public void ProductDetails(string pname)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    //SqlCommand cmd = new SqlCommand("select * from Product where Name like'" + pname + "%'", connection);
                    //connection.Open();
                    string Command = "Select * from Product where Name like @PrductName";
                    SqlCommand cmd = new SqlCommand(Command, connection);

                    cmd.Parameters.AddWithValue("@PrductName",pname+"%");

                    connection.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"], rd["Qty"]);
                    }
                }
                catch (Exception ee)
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
            ProductParameterizeQuery pInj = new ProductParameterizeQuery();
            string str = "t";
            pInj.ProductDetails(str);

        }
    }
}