using System;

namespace ClassLib_A5
{
    public class Calculator
    {
        static Calculator()
        {
            Console.WriteLine("\tMyCalculator Corporation\n");
        }
        public static int Square(int s)
        {
            return (s * s);
        }
        public static int Cube(int c)
        {
            return (c * c * c);
        }
    }
}
