using System;
/*1. create  a  static class having static method to find
	a. factorial of a number
	b.  square of a number
	c.  cube of a number.
Using  Anonymous  method.*/

namespace ConsoleApp_AnonymousMethodA1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAnonmous.MyFact(5);
            MyAnonmous.MySquare(5);
            MyAnonmous.MyCube(5);
        }
    }
}
