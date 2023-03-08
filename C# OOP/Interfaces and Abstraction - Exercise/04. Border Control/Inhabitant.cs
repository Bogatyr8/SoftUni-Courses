namespace BorderControl;

public abstract class Inhabitant : IInhabitant
{
    public Inhabitant(string id)
    {
        Id = id;
    }

    public string Id { get; set; }

    public override string ToString()
    {
        return Id;
    }
}
