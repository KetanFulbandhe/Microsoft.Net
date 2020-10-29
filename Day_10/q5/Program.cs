using System;
//Q5. Create a interface Itaxtogov with method void paytax(double amt) create a class myindia, myeurope let this class implement this interface.In class myindia  paytax method will print tax amount which is 40% of the data passed in method. In class myeurope  paytax method will print tax amount which is 30% of the data passed in method.

namespace ConsoleApp_TaxA5
{
    class Program
    {
        public static void calculateTax(Itaxtogov I)
        {
            I.paytax(10000);
        }
        static void Main(string[] args)
        {
            //myindia IN = new myindia();
            //myeurope EU = new myeurope();

            //IN.paytax(100);
            //EU.paytax(100);
            try
            {
                //Itaxtogov i1 = new myindia();
                //i1.paytax(1000);
                //Itaxtogov i2 = new myeurope();
                //i2.paytax(1000);
                calculateTax(new myindia());
                calculateTax(new myeurope());
            }
            catch
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
}
