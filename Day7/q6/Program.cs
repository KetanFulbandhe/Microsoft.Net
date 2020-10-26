using System;

//Accept a name from user accept password and confirm password from user if password and confirm password string are same give message valid data else print invalid data.
namespace ConsoleApp_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: \nPassword: \nConfirm Password: ");
            string name=Console.ReadLine();
            string pass = Console.ReadLine();
            string cpass = Console.ReadLine();
            Console.WriteLine((Object.Equals(pass, cpass)) ? "valid data" : "Invalid data");

            Console.ReadLine();
        }
    }
}
