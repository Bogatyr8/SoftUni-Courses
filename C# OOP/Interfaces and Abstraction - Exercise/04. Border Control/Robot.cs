namespace BorderControl;

public class Robot : Inhabitant, IInhabitant
{
    public Robot(string model, string id) : base(id)
    {
        Model = model;
    }

    public string Model { get; private set; }
}
