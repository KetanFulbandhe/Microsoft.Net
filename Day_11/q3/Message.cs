using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Message
    {
        public void email(int ts, int bns, string nm)
        {
            Console.WriteLine("E-mail : Total Salary : {0} Bonus={1} name={2}", ts, bns, nm);
        }
        public void mobile(int ts, int bns, string nm)
        {
            Console.WriteLine("\tMobile : Total Salary : {0} Bonus={1} name={2}", ts, bns, nm);
        }
    }
}
