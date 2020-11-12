using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication1
{
    public class Product
    {
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        string ConnectionString;
        SqlConnection connection;

        public void displayProduct()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(ConnectionString);

            dataAdapter = new SqlDataAdapter("select * from Product", connection);
            dataset = new DataSet();
            dataAdapter.FillSchema(dataset, SchemaType.Source, "Productt");
            dataAdapter.Fill(dataset, "Productt");
            DataTable dt = dataset.Tables["Productt"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine();

            }
        }
        public void MyInsert()
        {
            DataRow drCurrent = dataset.Tables["Productt"].NewRow();
            drCurrent["Id"] = 107;
            drCurrent["Name"] = "Bottle";
            drCurrent["Price"] = 80000;
            drCurrent["Qty"] = 5;

            dataset.Tables["Productt"].Rows.Add(drCurrent);
            Console.WriteLine("Add Successfully");
            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Productt");
            Console.WriteLine(co.GetInsertCommand().CommandText);
        }

        public void MyUpdate(int id)
        {
            DataRow dd = dataset.Tables["productt"].Rows.Find(id);
            dd["Name"] = "Mobile";
            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataset, "Productt");
            Console.WriteLine(co.GetUpdateCommand().CommandText);
        }
        public void MyDelete(int id)
        {
            DataRow dd = dataset.Tables["Productt"].Rows.Find(id);
            dd.Delete();
            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Productt");
            Console.WriteLine(co.GetDeleteCommand().CommandText);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p =new Product();

            p.displayProduct();
            p.MyInsert();
            p.MyUpdate(2002);
            p.MyDelete(2002);

            p.displayProduct();
        }
    }
}
