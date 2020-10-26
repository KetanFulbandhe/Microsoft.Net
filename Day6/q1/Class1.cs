using System;


namespace ClassLib_Banking_A1
{
    public class Account
    {
        static int getid;
        int _id;
        string _name;
        double _balance;
        static double Interestrate = 0.07;
        static Account()
        {
            Console.WriteLine("\tWelcome to Banking Application");
        }
        public Account(string nm, double bal)
        {
            if (bal > 0)
            {
                Name = nm;
                Balance = bal;
            }
            else
            {
                throw new Exception("negative and zero not allowed");
            }
        }
        public int ID
        {
            get { return ++getid; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value <= 0)
                    throw new Exception("negative or zero i not allowed");

                _balance = value;
            }
        }
        public void Deposite(double upamt)
        {
            Balance += upamt;
        }
        public void Withdraw(double dwamt)
        {
            const float minbal = 1000;
            if (_balance - dwamt < minbal)
            {
                throw new Exception("Need to Maintained 1000 amount");
            }
            else
            {
                Balance -= dwamt;
            }
        }
        public static double payint(Account obj)
        {

            double income = obj._balance * Interestrate;
            obj._balance = obj._balance + income;
            return income;
        }
        public string display()
        {
            return string.Format("\nID: {0} \nName: {1}\nBalance: {2}\nIntrest Received: {3}", this.ID, this.Name, this.Balance, payint(this));
        }


    }
}
