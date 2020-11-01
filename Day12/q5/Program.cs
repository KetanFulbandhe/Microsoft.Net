using System;
/*5. create a two partial Account class. In one class write only methods and another class write constructor and getter setter. Use this in your existing account application.*/

namespace ConsoleApp_PartialAccount_A5
{
    partial class Account
    {
        static int getid;
        int id;
        string name;
        double balanceamt;

        public void Display()
        {
            Console.WriteLine("ID {0} Name {1} Balance{2}",ID,Name,Balance);
        }
    }
    partial class Account
    {
        public Account(string nm, double bal)
        {
            id = ++getid;
            Name = nm;
            Balance = bal;
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return balanceamt; }
            set { balanceamt = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Tom",2000);
            a1.Display();

            Account a2 = new Account("Todd", 4000);
            a2.Display();

            Console.ReadLine();
        }
    }
}
