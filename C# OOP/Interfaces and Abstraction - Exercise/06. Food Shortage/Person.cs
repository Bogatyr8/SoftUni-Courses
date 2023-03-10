namespace FoodShortage;

public abstract class Person : IAging, IBuyer
{
    protected Person(string name, int age)
    {
        Name = name;
        Age = age;
        Food = 0;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }

    public int Food { get; protected set; }

    public abstract void BuyFood();

    public override string ToString()
    {
        return Food.ToString();
    }
}
