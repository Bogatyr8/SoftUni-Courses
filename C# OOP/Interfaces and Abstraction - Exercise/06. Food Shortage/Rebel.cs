namespace FoodShortage;

public class Rebel : Person, IBuyer
{
    public Rebel(string name, int age, string group) : base(name, age)
    {
        Group = group;
    }

    public string Group { get; private set; }

    public override void BuyFood()
    {
        Food += 5;
    }
}
