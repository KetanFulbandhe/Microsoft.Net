using System;
//create a class demomaths having method Square , cube which will take float value and return square and cube of a number.

namespace ConsoleApplication1_SquCubeClass
{
    class demomaths
    {
        public float Square(float s)
        {
            return s * s;
        }
        public float Cube(float c)
        {
            return c*c*c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demomaths Dsc = new demomaths();
            float square=Dsc.Square(5);
            float cube=Dsc.Cube(2);
            /*Console.WriteLine("Square: " + square);
            Console.WriteLine("Cube: " + cube);*/
            Console.WriteLine("Square: {0} \nCube: {1}", square, cube);
            Console.ReadLine();

        }
    }
}
