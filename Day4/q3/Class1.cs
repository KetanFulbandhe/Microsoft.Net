using System;

namespace ClassLibCustomer
{
    public class Customer
    {
        int Id;
        string name;
        int billamount;
        static Customer()
        {
            Console.WriteLine("\tMyCustomer Corporation");
        }
        public Customer()
        { }
        public string display()
        {
            return string.Format("{0},{1},{2}", Id, name, billamount);
        }
    }
}
