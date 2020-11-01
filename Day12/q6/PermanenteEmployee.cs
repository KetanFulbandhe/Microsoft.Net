using System;


namespace Employee
{
    public class PermanenteEmployee : Employee
    {
        public PermanenteEmployee(string pnm, int psal)
            : base(pnm, psal)
        {
        }
        public override void GiveBonus()
        {
            int Pbns = (int)(Salary * 0.2);
            Salary = (int)(Salary + Pbns);
            OnGiveBonus(Salary, Pbns, Name);

        }
    }
}
