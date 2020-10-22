using System;

namespace ClassLib_Printer
{
    public class Printer
    {
        private static Printer prnt;
        static Printer()
        {
            Console.WriteLine("\tMyPrinter Corporation");
        }
        private Printer()
        { }
        public static Printer Instance()
        {
            if (prnt == null)
                prnt = new Printer();

            return prnt;
        }
    }
}
