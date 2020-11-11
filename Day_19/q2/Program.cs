using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Q2. In the above example 
a. store employee record in database  using store procedure and strongly type insert.
b. Accept id and value for the name to update record.
using ExecutenonQuery() method
*/
namespace EmployeeInsertSPUpdt
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Name="Jenny",Salary=8000};
            EmployeeUpdateInsert indata = new EmployeeUpdateInsert();
            //int resi = indata.Adddata(e1);
            //Console.WriteLine("RowsAffected: {0}", resi);

            //update int id
            Console.WriteLine("update with id");
            int resid = indata.updateId(1003,"XYZ");                     
            Console.WriteLine("Updated record {0}", resid);

            
        }
    }
}
