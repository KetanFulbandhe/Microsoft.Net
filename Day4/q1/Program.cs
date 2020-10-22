using System;
using ClassLib_Banking;
//Create a class Account having private instance member Id, Name Balanceamt. Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder. Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder. Write method display which will display name and Balanceamt. This application will be classlibrary.
//Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.

namespace ConsoleApp_uselib_A1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(10,"Tom",500);
            Console.WriteLine("Inital details: "+a1.Display());
            a1.Deposit(200);
            Console.WriteLine("\tAfter Deposite 200: "+a1.Display());
            a1.Withdraw(100);
            Console.WriteLine("\tAfter Withdraw 100: "+a1.Display());

            Account a2 = new Account(10, "Tom", 1000);
            Console.WriteLine("Initial Details: {0}",a2.Display());
            a2.Deposit(500);
            Console.WriteLine("\tAfter Deposite 500: {0}",a2.Display());
            a2.Withdraw(200);
            Console.WriteLine("\tAfter Withdraw 200: {0}",a2.Display());
            
            Console.ReadLine();
        }
    }
}