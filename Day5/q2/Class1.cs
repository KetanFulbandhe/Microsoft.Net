using System;

namespace ClassLib_Banking_A2
{
    public class Account
    {
        static int getid;
        int Id;
        string Name;
        double Balanceamt;
        const int MaxCapacity = 3;
        static Account()
        {
            Console.WriteLine("\tWelcome to Virtual-Bank\n");
        }
        public Account(string nm, double bal)
        {
            if (getid < MaxCapacity)
            {
                Id = ++getid;
                Name = nm;
                Balanceamt = bal;
            }
            else
            {
                Console.WriteLine("\t***Can not create object***\n");
            }
        }
        public void Deposite(double upBal)
        {
            Balanceamt += upBal;
        }
        public void Withdraw(double dwBal)
        {
            const int miniBal = 100;
            if (Balanceamt - dwBal < miniBal)
            {
                Console.WriteLine("Low Balance");
            }
            else
                Balanceamt -= dwBal;
        }
        public string Display()
        {
            return string.Format("{0} {1} {2}", Id, Name, Balanceamt);
        }
    }
}
