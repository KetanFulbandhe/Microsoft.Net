using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ProductLikeStoredProcedure
{
    class ProductParameterizeQuery
    {
        public void ProductDetails(string pname)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("MySPlike", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", pname);
                try
                {
                    con.Open();
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
