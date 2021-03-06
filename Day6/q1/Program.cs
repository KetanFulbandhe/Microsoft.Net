﻿using System;
using ClassLib_Banking_A1;
//using ClassLib_Banking_A1;
/*Create Account class having instance member 
1. id- id should be generated by application, it is readonly property
2. name – write getter setter 
3. balance- Write getter setter 
Declare static float Interestrate=0.07.
It has deposit method who’s job is to increase the balance.
It has withdraw method who’s job is to reduce balance.
Declare conts float minbal=1000. When user withdraw money your application should ensure that minimum balance is maintain. 
Give appropriate validation like user can not deposit or withdraw 0 or negative. user can not open account with 0 amount
When you run your application at the beginning it should print name of bank and copy right detail.
It has static method which will calculate and return  interest amount for each account holder and increase the balance.
Write display method who’s job is to display Id name and balance and interest received.
If you are comfortable the exception try to use it and handle it also.*/

namespace ConsoleApp_uselib_Banking_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = null;
            Account a2 = null;
            Account a3 = null;
            try
            {
                //a1 = new Account("todd", 0);          //this line will not get executed due to exception(Invalide balance)
                //a1 = new Account("todd", -200);       //this line will not get executed due to exception(Invalide balance)
                a1 = new Account("todd", 2000);
                Console.WriteLine(a1.display()+" "+"\nCurrent Balance: "+a1.Balance);
                a2 = new Account("tom", 4000);
                Console.WriteLine(a2.display() + " " + "\nCurrent Balance: " + a2.Balance);
                a3 = new Account("John", 6000);
                Console.WriteLine(a3.display() + " " + "\nCurrent Balance: " + a3.Balance);

                Console.WriteLine("\n\tDepositing....\n");
                a1.Deposite(500);
                Console.WriteLine("\nName: " + a1.Name + " Balance: " + a1.Balance);
                
                a2.Deposite(600);
                Console.WriteLine("\nName: " + a2.Name + " Balance: " + a2.Balance);
                
                a3.Deposite(800);
                Console.WriteLine("\nName: " + a3.Name + " Balance: " + a3.Balance);
            }
            catch
            {
                Console.WriteLine("zero or Negative value not allowed");
            }
            try
            {
                //a1.Withdraw(1500);                    //this line will not get executed due to exception(MinBalance)
                Console.WriteLine("\n\tWithdrawing....");
                a1.Withdraw(200);
                Console.WriteLine("\nName: "+a1.Name+" Balance: "+a1.Balance);
                a2.Withdraw(200);
                Console.WriteLine("\nName: " + a2.Name + " Balance: " + a2.Balance);
                a1.Withdraw(200);
                Console.WriteLine("\nName: " + a3.Name + " Balance: " + a3.Balance);
            }
            catch
            {
                Console.WriteLine("\tNeed to Maintained 1000 amount");
                
            }
            Console.ReadLine();
        }
    }
}
