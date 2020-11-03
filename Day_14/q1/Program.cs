using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
/*Q1. In your account application add functionality of sort which will display data name wise ascending order.*/

namespace ConsoleApp_uselib_BankingA1
{
    [Serializable]
    abstract class Account
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
    [Serializable]
    class Saving : Account
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
    [Serializable]
    class Current : Account
    {
        public Current(String cnm, Double cbal)
            : base(cnm, cbal)
        { }

        public override void withdraw(double cdw)
        {
            Balance = Balance - cdw;
        }
    }

    //------------------------------------
    class Mysort : IComparer
    {
        public int Compare(object x, object y)
        {
            Account a1=x as Account;
            Account a2 = y as Account;

            if (a1 != null && a2 != null)
                return String.Compare(a1.Name, a2.Name);
            else
                throw new Exception("parameter is not Account type");
         }
    }

    class Program
    {
        //Serialisation
        static void SerializeMeSoap(object objGraph, string fileName)  
        {
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter MySoapFormater = new SoapFormatter();

            using (Stream fStream = new FileStream(fileName,
              FileMode.Create, FileAccess.Write))
            {
                MySoapFormater.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved Account in SOAP format!");
        }
        //DeSerialisation
        static void DeSerializeMeSoap(string str)
        {
            SoapFormatter MySoapFormaterDe=new SoapFormatter();
            using (Stream fStream = new FileStream(str, FileMode.Open))
            {
                Account[] obj = (Account[])MySoapFormaterDe.Deserialize(fStream);
                foreach (Account a in obj)
                    Console.WriteLine("{0} {1}", a.Name, a.Balance);
            }
        }

        static void Main(string[] args)
        {
            Account[] acArr = new Account[3];

            // acArr[0] = new Saving("abcdefghijklmnopqrst", 3000);     //Name length exceed than 15 character
            acArr[0] = new Current("Shriraj", 30000);
            acArr[1] = new Saving("Akshay", 15000);
            acArr[2] = new Saving("Ketan", 35000);

            foreach (Account i in acArr)
                Console.WriteLine(i.ToString());

            Console.WriteLine("\n\tDepositing 200 each....\n");
            try
            {
                foreach (Account i in acArr)
                {
                    //i.deposit(-200);                                   //Error amount can't be negative
                    i.deposit(200);
                    Console.WriteLine(i.ToString());
                }
            }
            catch
            {
                Console.WriteLine("Cant Deposite amount");
            }

            Console.WriteLine("\n\tWithdrawing 100 each....\n");
            try
            {
                foreach (Account i in acArr)
                {
                    if (i is Current)
                    {
                        i.withdraw(40000);               //current Account negative balance is allowed. 
                        Console.WriteLine(i.ToString());
                    }
                    else
                    {
                        i.withdraw(100);                 //Error: amount can't be negative
                        //i.withdraw(100);
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Can't withdraw amount");
            }            
            
            Console.WriteLine("\nName wise sorted data: \n");
            Array.Sort(acArr, new Mysort());

            foreach (Account i in acArr)
                Console.WriteLine(i.ToString());

            //Serialization

            Console.WriteLine("Serializing object in File...\n");
            SerializeMeSoap(acArr,"myAccount.soap");

            //DeSerialization
            Console.WriteLine("De-Serializing object from File...\n");
            string str = "myAccount.soap";
            DeSerializeMeSoap(str);

            Console.ReadLine();
        }
    }
    
}
