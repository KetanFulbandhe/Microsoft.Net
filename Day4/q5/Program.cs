using System;
using ClassLib_A5;
//Create a class calculator having  static method square, cube, absolute, floor,ceil who’s job is to find square, cube, absolute (-2.2 ==2.2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.

namespace ClassLib_uselib_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ansSq = Calculator.Square(2);
            int ansCu = Calculator.Cube(2);

            Console.WriteLine("Square: {0}\nCube: {1}\nAbsolute: {2}\nFloor: {3}\nCeil: {4}", ansSq, ansCu,Math.Abs(-2.2),Math.Floor(2.7),Math.Ceiling(2.9));

            Console.ReadLine();
        }
    }
}
