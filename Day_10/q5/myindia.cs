using System;
//In class myindia  paytax method will print tax amount which is 40% of the data passed in method.
namespace ConsoleApp_TaxA5
{
    public class myindia:Itaxtogov
    {

        public void paytax(double amt)
        {
            if (amt <= 0)
                throw new Exception("amount must positive");
            else
            {
                double tax = amt * 0.4;
                Console.WriteLine("Indian Tax: " + tax);
            }
        }
    }
}
