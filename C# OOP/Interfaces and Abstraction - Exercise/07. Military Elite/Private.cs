namespace MilitaryElite;

public class Private : Soldier
{
    public Private(string id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName)
    {
        Salary = salary;
    }

    public decimal Salary { get; private set; }
}
