using System;
//In class myeurope  paytax method will print tax amount which is 30% of the data passed in method.

namespace ConsoleApp_TaxA5
{
    public class myeurope:Itaxtogov
    {
        public void paytax(double amt)
        {
            if (amt <= 0)
                throw new Exception("amount must positive");
            else
            {
                double tax = amt * 0.3;
                Console.WriteLine("Europe Tax: " + tax);
            }
        }
    }
}
