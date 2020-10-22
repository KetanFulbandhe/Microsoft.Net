using System;
namespace ClassLib_Banking
{
    public class Account
    {
        int Id;
        string Name;
        int Balanceamt;
        static Account()
        {
            Console.WriteLine("\tMyBanking Corporation\n");
        }
        public Account(int id, string name, int Balamt)
        {
            Id = id;
            Name = name;
            Balanceamt = Balamt;
        }
        public int Deposit(int upBal)
        {
            return Balanceamt = Balanceamt + upBal;
        }
        public int Withdraw(int dwBal)
        {
            return Balanceamt = Balanceamt - dwBal;
        }
        public string Display()
        {
            //double nsal= calculate ();
            return string.Format("\n\tID: {0} Name: {1} Balance: {2}", Id, Name, Balanceamt);
        }
    }
}
