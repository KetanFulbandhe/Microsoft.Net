﻿using System;
using ClassLib_Banking_A2;
/*Create a class Account having private instance member Id, Name Balanceamt. Id should be generated by application. 
 * Create method deposit who’s job is to increase Balanceamtby the amout deposited by account holder. 
 * Create method withdraw who’s job is to decrease Balanceamt by the amount  withdrawn by account holder. 
 * Write method display which will display name and Balanceamt. 
 * Your application should generate only 3 object, if you try to generate 4 th object it should display message can not create object. This application will be classlibrary.
Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.*/

namespace ConsoleApp_uselib_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Sachin",2000);
            Account a2 = new Account("Virat", 4000);
            Account a3 = new Account("Shikhar", 6000);
            //Account a4 = new Account("Dhoni", 5000);   // gives error at this line MaxCapacity reach

            Console.WriteLine("Depositing....\n");
            a1.Deposite(200);
            a2.Deposite(400);
            a3.Deposite(600);
            //a4.Deposite(500);  

            Console.WriteLine(a1.Display());
            Console.WriteLine(a2.Display());
            Console.WriteLine(a3.Display());
            //Console.WriteLine(a4.Display());

            Console.WriteLine("\nWithdrawing....\n");
            a1.Withdraw(100);
            a2.Withdraw(300);
            a3.Withdraw(500);

            Console.WriteLine(a1.Display());
            Console.WriteLine(a2.Display());
            Console.WriteLine(a3.Display());

            Console.ReadLine();
        }
    }
}