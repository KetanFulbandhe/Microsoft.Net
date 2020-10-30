using System;

namespace Employee
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string tnm, int tsal)
            : base(tnm, tsal)
        {
        }
        public override void GiveBonus()
        {
            int tbns = (int)(Salary * 0.1);
            Salary = (int)(Salary + tbns);
            OnGiveBonus(Salary, tbns, Name);
        }
    }
}
