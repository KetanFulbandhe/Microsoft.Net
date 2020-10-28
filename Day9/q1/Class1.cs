using System;

namespace ClassLib_A1
{
    public abstract class Account
    {
        static int getid;
        int id;
        string name;
        double balanceamt;
        protected const double minbal = 1000;
        static Account()
        {
            Console.WriteLine("\tWelcome to MyBank\n");

        }
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
            set
            {
                if (value.Length > 15)
                    throw new Exception("Name length exceed than 15 character");
                else
                    name = value;
            }
        }
        public double Balance
        {
            get { return balanceamt; }
            protected set { balanceamt = value; }
        }
        public void deposit(double amt)
        {
            if (amt <= 0)
                throw new Exception("Amount must be positive number");
            else
                Balance = Balance + amt;
        }
        public abstract void withdraw(double dw);

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", ID, Name, Balance);
        }

    }
    public class Saving : Account
    {
        public Saving(String snm, Double sbal)
            : base(snm, sbal)
        { }
        public override void withdraw(double sdw)
        {
            if (Balance - sdw < minbal)
                throw new Exception("Balance can't be less then 1000");
            else
            {
                Balance = Balance - sdw;
            }
        }
    }
    public class Current : Account
    {
        public Current(String cnm, Double cbal)
            : base(cnm, cbal)
        { }

        public override void withdraw(double cdw)
        {
            Balance = Balance - cdw;
        }
    }
}
